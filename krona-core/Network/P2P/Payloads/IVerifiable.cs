using Krona.IO;
using Krona.Persistence;
using Krona.VM;
using System.IO;

namespace Krona.Network.P2P.Payloads
{
    public interface IVerifiable : ISerializable, IScriptContainer
    {
        Witness[] Witnesses { get; }

        void DeserializeUnsigned(BinaryReader reader);

        UInt160[] GetScriptHashesForVerifying(Snapshot snapshot);

        void SerializeUnsigned(BinaryWriter writer);
    }
}
