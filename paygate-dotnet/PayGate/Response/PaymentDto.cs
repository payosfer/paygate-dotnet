using paygate_dotnet.PayGate.Models;
using System.Collections.Generic;


namespace paygate_dotnet.PayGate.Responce

{
    public class PaymentDto : BasePaymentDto
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public long? FraudId { get; set; }
        public FraudAction? FraudAction { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
        public IList<PaymentTransaction> PaymentTransactions;
    }
}
