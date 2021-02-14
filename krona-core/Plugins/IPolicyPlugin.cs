using Krona.Network.P2P.Payloads;
using System.Collections.Generic;

namespace Krona.Plugins
{
    public interface IPolicyPlugin
    {
        bool FilterForMemoryPool(Transaction tx);
        IEnumerable<Transaction> FilterForBlock(IEnumerable<Transaction> transactions);
        int MaxTxPerBlock { get; }
        int MaxLowPriorityTxPerBlock { get; }
    }
}
