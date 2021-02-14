// krona-cli
using Krona.Shell;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Settings = Krona.Plugins.Settings;
using System;

namespace KronaCli.UnitTests
{
    [TestClass]
    public class UT_MainService
    {
        private static readonly Random _random = new Random(11121990);

        MainService uut;

        [TestInitialize]
        public void TestSetup()
        {
            uut = new MainService();
        }

        [TestMethod]
        public void TestTemplate()
        {
            // Nothing to do here now... put some tests
        }
    }
}
