﻿using Krona.Cryptography;
using Krona.IO;
using Krona.IO.Json;
using Krona.Ledger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Krona.Network.P2P.Payloads
{
    public class Block : BlockBase, IInventory, IEquatable<Block>
    {
        public const int MaxTransactionsPerBlock = ushort.MaxValue;

        public Transaction[] Transactions;

        private Header _header = null;
        public Header Header
        {
            get
            {
                if (_header == null)
                {
                    _header = new Header
                    {
                        PrevHash = PrevHash,
                        MerkleRoot = MerkleRoot,
                        Timestamp = Timestamp,
                        Index = Index,
                        ConsensusData = ConsensusData,
                        NextConsensus = NextConsensus,
                        Witness = Witness
                    };
                }
                return _header;
            }
        }

        InventoryType IInventory.InventoryType => InventoryType.Block;

        public override int Size => base.Size + Transactions.GetVarSize();

        public static Fixed8 CalculateNetFee(IEnumerable<Transaction> transactions)
        {
            Transaction[] ts = transactions.Where(p => p.Type != TransactionType.BlockReward).ToArray();
            Fixed8 amount_in = ts.SelectMany(p => p.References.Values.Where(o => o.AssetId == Blockchain.GoverningToken.Hash)).Sum(p => p.Value);
            Fixed8 amount_out = ts.SelectMany(p => p.Outputs.Where(o => o.AssetId == Blockchain.GoverningToken.Hash)).Sum(p => p.Value); ;
            return amount_in - amount_out;
        }

        public override void Deserialize(BinaryReader reader)
        {
            base.Deserialize(reader);
            Transactions = new Transaction[reader.ReadVarInt(MaxTransactionsPerBlock)];
            if (Transactions.Length == 0) throw new FormatException();
            HashSet<UInt256> hashes = new HashSet<UInt256>();
            for (int i = 0; i < Transactions.Length; i++)
            {
                Transactions[i] = Transaction.DeserializeFrom(reader);
                if (i == 0)
                {
                    if (Transactions[0].Type != TransactionType.BlockReward)
                        throw new FormatException();
                }
                else
                {
                    if (Transactions[i].Type == TransactionType.BlockReward)
                        throw new FormatException();
                }
                if (!hashes.Add(Transactions[i].Hash))
                    throw new FormatException();
            }
            if (MerkleTree.ComputeRoot(Transactions.Select(p => p.Hash).ToArray()) != MerkleRoot)
                throw new FormatException();
        }

        public bool Equals(Block other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;
            return Hash.Equals(other.Hash);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Block);
        }

        public override int GetHashCode()
        {
            return Hash.GetHashCode();
        }

        public void RebuildMerkleRoot()
        {
            MerkleRoot = MerkleTree.ComputeRoot(Transactions.Select(p => p.Hash).ToArray());
        }

        public override void Serialize(BinaryWriter writer)
        {
            base.Serialize(writer);
            writer.Write(Transactions);
        }

        public override JObject ToJson()
        {
            JObject json = base.ToJson();
            json["tx"] = Transactions.Select(p => p.ToJson()).ToArray();
            return json;
        }

        public TrimmedBlock Trim()
        {
            return new TrimmedBlock
            {
                Version = Version,
                PrevHash = PrevHash,
                MerkleRoot = MerkleRoot,
                Timestamp = Timestamp,
                Index = Index,
                ConsensusData = ConsensusData,
                NextConsensus = NextConsensus,
                Witness = Witness,
                Hashes = Transactions.Select(p => p.Hash).ToArray()
            };
        }
    }
}
