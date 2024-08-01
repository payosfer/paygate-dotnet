using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Models
{
    public  enum RefundDestinationType
    {
        [EnumMember(Value = "CARD")]
        CARD,
        [EnumMember(Value = "WALLET")] WALLET
    }
}
