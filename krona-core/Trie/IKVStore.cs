
namespace Krona.Trie
{
    public interface IKVStore : IKVReadOnlyStore
    {
        void Put(byte[] key, byte[] value);
    }
}
