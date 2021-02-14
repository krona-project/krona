#pragma warning disable CS0612

using Krona.IO.Caching;

namespace Krona.Network.P2P.Payloads
{
    public enum TransactionType : byte
    {
        [ReflectionCache(typeof(BlockReward))]
        BlockReward = 0x00,
        [ReflectionCache(typeof(RegisterTransaction))]
        RegisterTransaction = 0x40,
        [ReflectionCache(typeof(P2PTransaction))]
        P2PTransaction = 0x80,
        [ReflectionCache(typeof(StateTransaction))]
        StateTransaction = 0x90,
        /// <summary>
        /// Publish scripts to the blockchain for being invoked later.
        /// </summary>
        [ReflectionCache(typeof(InvocationTransaction))]
        InvocationTransaction = 0xd1
    }
}
