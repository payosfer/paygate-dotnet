using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Request
{
    public  class InitThreeDSPaymentInput :CreatePaymentInput
    {
        public string SuccessUrl { get; set; }

        public string ErrorUrl { get; set; }
    }
}
