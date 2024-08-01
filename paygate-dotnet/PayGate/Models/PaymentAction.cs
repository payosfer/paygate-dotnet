using System.Runtime.Serialization;

namespace paygate_dotnet.PayGate.Models
{
    public enum PaymentAction
    {
        [EnumMember(Value = "AUTH")] AUTH,
        [EnumMember(Value = "PRE_AUTH")] PRE_AUTH,
        [EnumMember(Value = "POST_AUTH")] POST_AUTH
    }
}
