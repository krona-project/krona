using Krona.Persistence;

namespace Krona.Network.P2P.Payloads
{
    public interface IInventory : IVerifiable
    {
        UInt256 Hash { get; }

        InventoryType InventoryType { get; }

        bool Verify(Snapshot snapshot);
    }
}
