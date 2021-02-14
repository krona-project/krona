using Krona.Network.P2P.Payloads;
using System.Collections.Generic;

namespace Krona.Plugins
{
    public interface IMemoryPoolTxObserverPlugin
    {
        void TransactionAdded(Transaction tx);
        void TransactionsRemoved(MemoryPoolTxRemovalReason reason, IEnumerable<Transaction> transactions);
    }
}
