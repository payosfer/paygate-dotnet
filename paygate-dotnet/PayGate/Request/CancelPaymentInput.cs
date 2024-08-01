using paygate_dotnet.PayGate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Request
{
    public class CancelPaymentInput
    {
        public long? PaymentId { get; set; }

        public string RRN { get; set; }

        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.CARD;

        public bool ChargeFromMe { get; set; } = false;

        public string CancelDescription { get; set; }

        public string EmailAddress { get; set; }

        public long TerminalId { get; set; }
    }
}
