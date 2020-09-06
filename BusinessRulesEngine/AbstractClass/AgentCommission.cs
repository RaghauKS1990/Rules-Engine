using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessRulesEngine.AbstractClass
{
    public abstract class AgentCommission
    {
        public bool GetAgentCommission()
        {
            // if Commission percentage is same then We can use this methos if both PhysicalProducts and Book, Since it use same code
            // else Commission percentage is different per product then IAgentCommission is better option for Implemeting it 
            return true;
        }
    }
}
