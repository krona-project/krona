using Akka.Actor;
using Krona.Ledger;
using Krona.Network.P2P.Payloads;
using Krona.Persistence;
using Krona.SmartContract;
using Krona.Wallets;
using System;
using System.Linq;

namespace Krona.Shell
{

    public class Coins
    {
        private Wallet current_wallet;
        private KronaSystem system;
        public static int MAX_CLAIMS_AMOUNT = 50;

        public Coins(Wallet wallet, KronaSystem system)
        {
            this.current_wallet = wallet;
            this.system = system;
        }

        public Fixed8 UnavailableBonus()
        {
            using (Snapshot snapshot = Blockchain.Singleton.GetSnapshot())
            {
                uint height = snapshot.Height + 1;
                Fixed8 unavailable;

                try
                {
                    unavailable = snapshot.CalculateBonus(current_wallet.FindUnspentCoins().Where(p => p.Output.AssetId.Equals(Blockchain.GoverningToken.Hash)).Select(p => p.Reference), height);
                }
                catch (Exception)
                {
                    unavailable = Fixed8.Zero;
                }

                return unavailable;
            }
        }


        public Fixed8 AvailableBonus()
        {
            using (Snapshot snapshot = Blockchain.Singleton.GetSnapshot())
            {
                return snapshot.CalculateBonus(current_wallet.GetUnclaimedCoins().Select(p => p.Reference));
            }
        }

        private Transaction SignTransaction(Transaction tx)
        {
            if (tx == null)
            {
                Console.WriteLine($"no transaction specified");
                return null;
            }
            ContractParametersContext context;

            try
            {
                context = new ContractParametersContext(tx);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"unsynchronized block");

                return null;
            }

            current_wallet.Sign(context);

            if (context.Completed)
            {
                tx.Witnesses = context.GetWitnesses();
                current_wallet.ApplyTransaction(tx);

                bool relay_result = system.Blockchain.Ask<RelayResultReason>(tx).Result == RelayResultReason.Succeed;

                if (relay_result)
                {
                    return tx;
                }
                else
                {
                    Console.WriteLine($"Local Node could not relay transaction: {tx.Hash.ToString()}");
                }
            }
            else
            {
                Console.WriteLine($"Incomplete Signature: {context.ToString()}");
            }

            return null;
        }
    }
}
