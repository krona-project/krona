
namespace Krona.Trie
{
    public interface IKVReadOnlyStore
    {
        byte[] Get(byte[] key);
    }
}
