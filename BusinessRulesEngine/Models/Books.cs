using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    // if Commission percentage is same then We can use this Abstract AgentCommission class with concrete method, Since it use same code for both PhysicalProducts and Book
    // else Commission percentage is different per product then IAgentCommission is better option for Implemeting it 

    //public class Books : AgentCommission,IPayment, IAgentCommission
    public class Books : IPayment, IAgentCommission
    {
        private string Name { get; set; }
        private string Version { get; set; }

        public Books()
        {
            // Initialize fields here as per the requirments
        }

        public bool PackingSlip()
        {
            // Logic should be implement here as per the requirments
            return true;
        }

        public bool AgentCommission()
        {
            // Logic should be implement here as per the requirments
            return true;
        }
    }
}
