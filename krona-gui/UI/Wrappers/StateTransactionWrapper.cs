﻿using Krona.Network.P2P.Payloads;
using System.Collections.Generic;
using System.Linq;

namespace Krona.UI.Wrappers
{
    internal class StateTransactionWrapper : TransactionWrapper
    {
        public List<StateDescriptorWrapper> Descriptors { get; set; } = new List<StateDescriptorWrapper>();

        public override Transaction Unwrap()
        {
            StateTransaction tx = (StateTransaction)base.Unwrap();
            tx.Descriptors = Descriptors.Select(p => p.Unwrap()).ToArray();
            return tx;
        }
    }
}
