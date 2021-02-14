using FluentAssertions;
using Krona;
using Krona.Network.P2P.Payloads;
using Krona.Persistence;
using Krona.Plugins;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Settings = Krona.Plugins.Settings;

namespace SimplePolicy.UnitTests
{
    [TestClass]
    public class UT_SimplePolicy
    {
        private static readonly Random _random = new Random(11121990);

        SimplePolicyPlugin uut;

        [TestInitialize]
        public void TestSetup()
        {
            uut = new SimplePolicyPlugin();
        }

        [TestMethod]
        public void TestMaxTransactionsPerBlock()
        {
            Settings.Default.MaxTransactionsPerBlock.Should().Be(200);
            Settings.Default.MaxFreeTransactionsPerBlock.Should().Be(199);
        }

        [TestMethod]
        public void FreeTxVerifySort_NoHighPriority()
        {
            List<Transaction> txList = new List<Transaction>();
            // three different sizes, but it doesn't matter
            for (var size = 10; size <= 20; size += 5)
            {
                for (var netFeeSatoshi = 0; netFeeSatoshi <= 90000; netFeeSatoshi += 10000)
                {
                    var testTx = MockGenerateInvocationTransaction(new Fixed8(netFeeSatoshi), size).Object;
                    testTx.IsLowPriority.Should().Be(true); // "LowPriorityThreshold": 0.001
                    txList.Insert(0, testTx);
                }
            }

            txList.Count.Should().Be(30);
            // transactions => size: [10, 15, 20] x price: [0 ... 90000, step by 10000]
            //foreach(var tx in txList)
            //    Console.WriteLine($"TX fee: {tx.NetworkFee} size: {tx.Size} ratio: {tx.FeePerByte}");
            /*
             TX fee: 0.0009 size: 20 ratio: 0.000045
             TX fee: 0.0008 size: 20 ratio: 0.00004
             TX fee: 0.0007 size: 20 ratio: 0.000035
             TX fee: 0.0006 size: 20 ratio: 0.00003
             TX fee: 0.0005 size: 20 ratio: 0.000025
             TX fee: 0.0004 size: 20 ratio: 0.00002
             TX fee: 0.0003 size: 20 ratio: 0.000015
             TX fee: 0.0002 size: 20 ratio: 0.00001
             TX fee: 0.0001 size: 20 ratio: 0.000005
             TX fee: 0 size: 20 ratio: 0
             TX fee: 0.0009 size: 15 ratio: 0.00006
             TX fee: 0.0008 size: 15 ratio: 0.00005333
             TX fee: 0.0007 size: 15 ratio: 0.00004666
             TX fee: 0.0006 size: 15 ratio: 0.00004
             TX fee: 0.0005 size: 15 ratio: 0.00003333
             TX fee: 0.0004 size: 15 ratio: 0.00002666
             TX fee: 0.0003 size: 15 ratio: 0.00002
             TX fee: 0.0002 size: 15 ratio: 0.00001333
             TX fee: 0.0001 size: 15 ratio: 0.00000666
             TX fee: 0 size: 15 ratio: 0
             TX fee: 0.0009 size: 10 ratio: 0.00009
             TX fee: 0.0008 size: 10 ratio: 0.00008
             TX fee: 0.0007 size: 10 ratio: 0.00007
             TX fee: 0.0006 size: 10 ratio: 0.00006
             TX fee: 0.0005 size: 10 ratio: 0.00005
             TX fee: 0.0004 size: 10 ratio: 0.00004
             TX fee: 0.0003 size: 10 ratio: 0.00003
             TX fee: 0.0002 size: 10 ratio: 0.00002
             TX fee: 0.0001 size: 10 ratio: 0.00001
            */

            IEnumerable<Transaction> filteredTxList = uut.FilterForBlock(txList);
            filteredTxList.Count().Should().Be(30);

            // will select top 20
            // part A: 18 transactions with ratio >= 0.000025
            // part B: 2 transactions with ratio = 0.00002 (but one with this ratio will be discarded, with fee 0.0002)
            //foreach(var tx in filteredTxList)
            //    Console.WriteLine($"TX20 fee: {tx.NetworkFee} size: {tx.Size} ratio: {tx.NetworkFee / tx.Size}");
            /*
            TX20 fee: 0.0009 size: 10 ratio: 0.00009
            TX20 fee: 0.0008 size: 10 ratio: 0.00008
            TX20 fee: 0.0007 size: 10 ratio: 0.00007
            TX20 fee: 0.0009 size: 15 ratio: 0.00006
            TX20 fee: 0.0006 size: 10 ratio: 0.00006
            TX20 fee: 0.0008 size: 15 ratio: 0.00005333
            TX20 fee: 0.0005 size: 10 ratio: 0.00005
            TX20 fee: 0.0007 size: 15 ratio: 0.00004666
            TX20 fee: 0.0009 size: 20 ratio: 0.000045
            TX20 fee: 0.0008 size: 20 ratio: 0.00004
            TX20 fee: 0.0006 size: 15 ratio: 0.00004
            TX20 fee: 0.0004 size: 10 ratio: 0.00004
            TX20 fee: 0.0007 size: 20 ratio: 0.000035
            TX20 fee: 0.0005 size: 15 ratio: 0.00003333
            TX20 fee: 0.0006 size: 20 ratio: 0.00003
            TX20 fee: 0.0003 size: 10 ratio: 0.00003
            TX20 fee: 0.0004 size: 15 ratio: 0.00002666
            TX20 fee: 0.0005 size: 20 ratio: 0.000025
            TX20 fee: 0.0004 size: 20 ratio: 0.00002
            TX20 fee: 0.0003 size: 15 ratio: 0.00002
            */

            // part A
            filteredTxList.Where(tx => (tx.NetworkFee / tx.Size) >= new Fixed8(2500)).Count().Should().Be(18); // 18 enter in part A
            txList.Where(tx => (tx.NetworkFee / tx.Size) >= new Fixed8(2500)).Count().Should().Be(18); // they also exist in main list
            txList.Where(tx => (tx.NetworkFee / tx.Size) < new Fixed8(2500)).Count().Should().Be(30 - 18); // 12 not selected transactions in part A
            // part B
            filteredTxList.Where(tx => (tx.NetworkFee / tx.Size) < new Fixed8(2500)).Count().Should().Be(12); // only two enter in part B
            filteredTxList.Where(tx => (tx.NetworkFee / tx.Size) == new Fixed8(2000)).Count().Should().Be(3); // only two enter in part B with ratio 0.00002
            txList.Where(tx => (tx.NetworkFee / tx.Size) == new Fixed8(2000)).Count().Should().Be(3); // 3 in tie (ratio 0.00002)
            txList.Where(tx => (tx.NetworkFee / tx.Size) == new Fixed8(2000) && (tx.NetworkFee > new Fixed8(20000))).Count().Should().Be(2); // only 2 survive (fee > 0.0002)
        }

        [TestMethod]
        public void FreeTxVerifySortWithPriority()
        {

        }

        [TestMethod]
        public void TestMock_GenerateInvocationTransaction()
        {
            var txHighPriority = MockGenerateInvocationTransaction(Fixed8.One, 50);
            // testing default values
            Fixed8 txHighPriority_ratio = txHighPriority.Object.NetworkFee / txHighPriority.Object.Size;
            txHighPriority_ratio.Should().Be(new Fixed8(2000000)); // 0.02
            txHighPriority.Object.IsLowPriority.Should().Be(false);

            var txLowPriority = MockGenerateInvocationTransaction(Fixed8.One / 10000, 50); // 0.00001
            // testing default values
            Fixed8 txLowPriority_ratio = txLowPriority.Object.NetworkFee / txLowPriority.Object.Size;
            txLowPriority_ratio.Should().Be(new Fixed8(200)); // 0.000002  -> 200 satoshi / Byte
            txLowPriority.Object.IsLowPriority.Should().Be(true);
        }

        [TestMethod]
        public void TestVerifySizeLimits_FreeLessEq1024()
        {
            var txLowPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 10000), 1024).Object; // 0.00001
            txLowPriority.IsLowPriority.Should().Be(true);
            txLowPriority.Size.Should().Be(1024);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);

            uut.VerifySizeLimits(txLowPriority).Should().Be(true); // 1024 <= 1024
        }

        [TestMethod]
        public void TestVerifySizeLimits_FreeGreater1024()
        {
            var txLowPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 10000), 1025).Object; // 0.00001
            txLowPriority.IsLowPriority.Should().Be(true);
            txLowPriority.Size.Should().Be(1025);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);

            uut.VerifySizeLimits(txLowPriority).Should().Be(false); // 1025 > 1024
        }

        [TestMethod]
        public void TestVerifySizeLimits_HighPriorityLessEq1024()
        {
            var txHighPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 1000), 1024).Object; // 0.0001
            txHighPriority.IsLowPriority.Should().Be(false);
            txHighPriority.Size.Should().Be(1024);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);

            uut.VerifySizeLimits(txHighPriority).Should().Be(true); // 1024 <= 1024
        }

        [TestMethod]
        public void TestVerifySizeLimits_HighPriorityGreater1024_1025()
        {
            var txHighPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 1000), 1025).Object; // 0.0001
            txHighPriority.IsLowPriority.Should().Be(false);
            txHighPriority.Size.Should().Be(1025);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);
            Settings.Default.FeePerExtraByte.Should().Be(new Fixed8(100000000 / 100000)); // 0.000001 (1000 satoshi)

            uut.VerifySizeLimits(txHighPriority).Should().Be(true); // 1025 > 1024 (extra fee was 1 byte * 1000 satoshi = 0.000001)
        }

        [TestMethod]
        public void TestVerifySizeLimits_HighPriorityGreater1024_1124()
        {
            var txHighPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 1000), 1124).Object; // 0.0001
            txHighPriority.IsLowPriority.Should().Be(false);
            txHighPriority.Size.Should().Be(1124);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);
            Settings.Default.FeePerExtraByte.Should().Be(new Fixed8(100000000 / 100000)); // 0.000001 (1000 satoshi)

            uut.VerifySizeLimits(txHighPriority).Should().Be(true); // 1124 > 1024 (extra fee was 100 byte * 1000 satoshi = 0.0001)
        }

        [TestMethod]
        public void TestVerifySizeLimits_HighPriorityGreater1024_1125_unpaid_fails()
        {
            var txHighPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 1000), 1125).Object; // 0.0001
            txHighPriority.IsLowPriority.Should().Be(false);
            txHighPriority.Size.Should().Be(1125);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);
            Settings.Default.FeePerExtraByte.Should().Be(new Fixed8(100000000 / 100000)); // 0.000001 (1000 satoshi)
            // should fail because of 1000 unpaid satoshi... (1 byte over)
            uut.VerifySizeLimits(txHighPriority).Should().Be(false); // 1125 > 1024 (extra fee was 101 byte * 1000 satoshi = 0.0001001)
        }

        [TestMethod]
        public void TestVerifySizeLimits_HighPriorityGreater1024_1125_paid_NotFail()
        {
            var txHighPriority = MockGenerateInvocationTransaction(new Fixed8(100000000 / 1000 + 1000), 1125).Object; // 0.000101
            txHighPriority.IsLowPriority.Should().Be(false);
            txHighPriority.Size.Should().Be(1125);
            Settings.Default.MaxFreeTransactionSize.Should().Be(1024);
            Settings.Default.FeePerExtraByte.Should().Be(new Fixed8(100000000 / 100000)); // 0.000001 (1000 satoshi)
            // should pass (total charged is 0.000101)
            uut.VerifySizeLimits(txHighPriority).Should().Be(true); // 1125 > 1024 (extra fee was 101 byte * 1000 satoshi = 0.000101)
        }

        // Generate Mock InvocationTransaction with different sizes and prices
        public static Mock<InvocationTransaction> MockGenerateInvocationTransaction(Fixed8 networkFee, int size)
        {
            var mockTx = new Mock<InvocationTransaction>();
            mockTx.SetupGet(mr => mr.NetworkFee).Returns(networkFee);
            mockTx.SetupGet(mr => mr.Size).Returns(size);

            //==============================
            //=== Generating random Hash ===
            mockTx.CallBase = true;
            mockTx.Setup(p => p.Verify(It.IsAny<Snapshot>(), It.IsAny<IEnumerable<Transaction>>())).Returns(true);
            var tx = mockTx.Object;
            var randomBytes = new byte[16];
            _random.NextBytes(randomBytes);
            tx.Script = randomBytes;
            tx.Attributes = new TransactionAttribute[0];
            tx.Inputs = new CoinReference[0];
            tx.Outputs = new TransactionOutput[0];
            tx.Witnesses = new Witness[0];
            //==============================

            return mockTx;
        }

        public static CoinReference GetCoinReference(UInt256 prevHash)
        {
            if (prevHash == null) prevHash = UInt256.Zero;
            return new CoinReference
            {
                PrevHash = prevHash,
                PrevIndex = 0
            };
        }
    }
}
