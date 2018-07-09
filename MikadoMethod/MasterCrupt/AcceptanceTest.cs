using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MasterCrupt
{
    public class AcceptanceTest
    {
        [Fact]
        public void TestSecret()
        {
            UI ui = new UI();
            Assert.Equal(
                expected: "Leeted: S3cr3t", 
                actual: ui.EncryptMessage("Secret"));
        }
    }
}
