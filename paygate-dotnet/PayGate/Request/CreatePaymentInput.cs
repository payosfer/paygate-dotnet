using paygate_dotnet.PayGate.Models;
using paygate_dotnet.PayGate.Modelspaygate_dotnet;
using paygate_dotnet.PayGate.Responce;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Request
{
    public class CreatePaymentInput
    {
        public long? TerminalId { get; set; }

        public long? MerchantId { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Tutar sıfırdan küçük olamaz.")]
        public decimal Amount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal WalletAmount { get; set; } = decimal.Zero;

        public string PosAlias { get; set; }

        public int? Installment { get; set; }

        public Currency? Currency { get; set; }

        public string PaymentDescription { get; set; }

        public string RRN { get; set; }

        public string Hash { get; set; }

        public string WebURL { get; set; }

        public string ExternalId { get; set; }

        public PaymentAction Action { get; set; }

        public PaymentType? PaymentType { get; set; }

        public long? BuyerMemberId { get; set; }

        public string BankOrderId { get; set; }

        public string ClientIp { get; set; }

        public CardDto Card { get; set; }

        public FraudCheckParameters FraudCheckParameters { get; set; }

        public IList<CustomItems> CustomItems { get; set; }

        public Dictionary<string, object> AdditionalParams { get; set; }

        public bool Retry { get; set; } = true;
    }
}
