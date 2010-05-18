using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    [NUnit.Framework.TestFixture]
    public class AcceptanceTest
    {
        [NUnit.Framework.Test]
        public void TestSecret()
        {
            UI ui = new UI();
            NUnit.Framework.Assert.AreEqual("Leeted: S3cr3t", ui.EncryptMessage("Secret"));
        }
    }
}
