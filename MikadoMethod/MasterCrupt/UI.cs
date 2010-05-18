using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class UI {
        Application application = new Application(); 
        private string leeted;
        
        public string EncryptMessage(string unLeeted) 
        {
            application.Leet(unLeeted, this);
            return "Leeted: " + leeted;
        }

        public void SetLeeted(string leeted) 
        {
            this.leeted = leeted;
        }
    }
}
