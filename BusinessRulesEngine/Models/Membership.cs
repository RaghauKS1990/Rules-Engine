using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    public class Membership: IActivate,IEmailService
    {
        private string Name { get; set; }
        private string MembershipCard { get; set; }
        private int MembershipNumber { get; set; }

        public Membership()
        {
            // Initialize fields here as per the requirments
        }

        public bool Activate()
        {
            // Logic should be implement here as per the requirments
            return true;
        }

        public bool SendMail()
        {
            // Logic should be implement here as per the requirments
            return true;
        }
    }
}
