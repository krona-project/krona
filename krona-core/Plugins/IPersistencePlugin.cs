using Krona.Persistence;
using System;
using System.Collections.Generic;
using static Krona.Ledger.Blockchain;

namespace Krona.Plugins
{
    public interface IPersistencePlugin
    {
        void OnPersist(Snapshot snapshot, IReadOnlyList<ApplicationExecuted> applicationExecutedList);
        void OnCommit(Snapshot snapshot);
        bool ShouldThrowExceptionFromCommit(Exception ex);
    }
}
