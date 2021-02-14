using Krona.IO;
using Krona.Network.P2P.Payloads;
using System;
using System.IO;
using System.Linq;

namespace Krona.Consensus
{
    public class PrepareRequest : ConsensusMessage
    {
        public uint Timestamp;
        public ulong Nonce;
        public UInt160 NextConsensus;
        public UInt256[] TransactionHashes;
        public BlockReward BlockReward;
        public byte[] StateRootSignature;

        public override int Size => base.Size
            + sizeof(uint)                      //Timestamp
            + sizeof(ulong)                     //Nonce
            + NextConsensus.Size                //NextConsensus
            + TransactionHashes.GetVarSize()    //TransactionHashes
            + BlockReward.Size             //BlockReward
            + StateRootSignature.Length;        //StateRootSignature

        public PrepareRequest()
            : base(ConsensusMessageType.PrepareRequest)
        {
        }

        public override void Deserialize(BinaryReader reader)
        {
            base.Deserialize(reader);
            Timestamp = reader.ReadUInt32();
            Nonce = reader.ReadUInt64();
            NextConsensus = reader.ReadSerializable<UInt160>();
            TransactionHashes = reader.ReadSerializableArray<UInt256>(Block.MaxTransactionsPerBlock);
            if (TransactionHashes.Distinct().Count() != TransactionHashes.Length)
                throw new FormatException();
            BlockReward = reader.ReadSerializable<BlockReward>();
            if (BlockReward.Hash != TransactionHashes[0])
                throw new FormatException();
            StateRootSignature = reader.ReadBytes(64);
        }

        public override void Serialize(BinaryWriter writer)
        {
            base.Serialize(writer);
            writer.Write(Timestamp);
            writer.Write(Nonce);
            writer.Write(NextConsensus);
            writer.Write(TransactionHashes);
            writer.Write(BlockReward);
            writer.Write(StateRootSignature);
        }
    }
}
