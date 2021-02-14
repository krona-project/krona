using Krona.SmartContract.Enumerators;
using Krona.VM;

namespace Krona.SmartContract.Iterators
{
    internal interface IIterator : IEnumerator
    {
        StackItem Key();
    }
}
