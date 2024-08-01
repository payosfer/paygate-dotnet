namespace paygate_dotnet.PayGate.Modelspaygate_dotnet
{
    public class CustomItems
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string ExternalId { get; set; }
        public long? SubMerchantMemberId { get; set; }
        public decimal SubMerchantMemberAmount { get; set; }
    }
}
