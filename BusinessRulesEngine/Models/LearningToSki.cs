using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    public class LearningToSki: IPayment
    {
        private string VideoName { get; set; }
        private string VideoVersion { get; set; }

        public LearningToSki()
        {
            // Initialize fields here as per the requirments
        }

        public bool PackingSlip()
        {
            // Logic should be implement here as per the requirments
            return true;
        }
    }
}
