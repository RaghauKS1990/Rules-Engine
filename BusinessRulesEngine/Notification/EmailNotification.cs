using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Notification
{
    public class EmailNotification
    {
        private IEmailService _iEmailService;
        public EmailNotification(IEmailService messenger)
        {
            _iEmailService = messenger;
        }
        public bool DoEmailNotify()
        {
            return _iEmailService.SendMail();
        }
    }
}
