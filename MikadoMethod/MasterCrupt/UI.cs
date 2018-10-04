using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class UI
    {
        private Application _application = new Application(); 
        private string _leeted;
        
        public string LeetMessage(string unLeeted) 
        {
            _application.Leet(unLeeted, this);
            return "Leeted: " + _leeted;
        }

        public void SetLeeted(string leeted) 
        {
            _leeted = leeted;
        }
    }
}
