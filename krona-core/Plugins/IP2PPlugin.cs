using Krona.Network.P2P;
using Krona.Network.P2P.Payloads;

namespace Krona.Plugins
{
    public interface IP2PPlugin
    {
        bool OnP2PMessage(Message message);
        bool OnConsensusMessage(ConsensusPayload payload);
    }
}
