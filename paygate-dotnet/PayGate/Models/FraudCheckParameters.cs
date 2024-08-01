namespace paygate_dotnet.PayGate.Models
{
    public class FraudCheckParameters
    {
        public string BuyerExternalId { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerEmail { get; set; }
    }
}
