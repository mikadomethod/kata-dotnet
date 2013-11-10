using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterCrupt
{
    [TestClass]
    public class AcceptanceTest
    {
        [TestMethod]
        public void TestSecret()
        {
            UI ui = new UI();
            Assert.AreEqual("Leeted: S3cr3t", ui.EncryptMessage("Secret"));
        }
    }
}
