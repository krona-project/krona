using System;
using System.IO;

namespace Krona.Network.P2P.Payloads
{
    public class P2PTransaction : Transaction
    {
        public P2PTransaction()
            : base(TransactionType.P2PTransaction)
        {
        }

        protected override void DeserializeExclusiveData(BinaryReader reader)
        {
            if (Version != 0) throw new FormatException();
        }
    }
}
