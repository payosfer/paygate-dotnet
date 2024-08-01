using System.Data.Metadata.Edm;
using System.Runtime.Serialization;

namespace paygate_dotnet.PayGate.Models
{
    public enum Currency
    {
        [EnumMember(Value = "TRY")] TRY,
        [EnumMember(Value = "USD")] USD,
        [EnumMember(Value = "EUR")] EUR,
        [EnumMember(Value = "GBP")] GBP,
        [EnumMember(Value = "ARS")] ARS,
        [EnumMember(Value = "BRL")] BRL,
        [EnumMember(Value = "CNY")] CNY,
        [EnumMember(Value = "AED")] AED,
        [EnumMember(Value = "IQD")] IQD
    }
}
