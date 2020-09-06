using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Notification
{

    public class AgentCommissionNotification
    {
        private IAgentCommission _iAgentCommission;
        public AgentCommissionNotification(IAgentCommission agentCommission)
        {
            _iAgentCommission = agentCommission;
        }
        public bool DoAgentCommissionNotify()
        {
            return _iAgentCommission.AgentCommission();
        }
    }
}
