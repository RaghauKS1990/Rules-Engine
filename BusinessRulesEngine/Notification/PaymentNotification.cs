using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Notification
{
    public class PaymentNotification
    {
        private IPayment _iPayment;
        public PaymentNotification(IPayment pPackingSlip)
        {
            _iPayment = pPackingSlip;
        }
        public bool DoPaymentNotify()
        {
            return _iPayment.PackingSlip();
        }
    }
}
