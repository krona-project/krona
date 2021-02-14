using Krona.VM;
using System;

namespace Krona.SmartContract.Enumerators
{
    internal interface IEnumerator : IDisposable
    {
        bool Next();
        StackItem Value();
    }
}
