﻿namespace Krona.VM
{
    public interface IInteropService
    {
        bool Invoke(byte[] method, ExecutionEngine engine);
    }
}
