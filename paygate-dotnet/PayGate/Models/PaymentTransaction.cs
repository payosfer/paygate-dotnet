using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Models
{
    public  class PaymentTransaction
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal WalletAmount { get; set; }
        public decimal MerchantCommissionRate { get; set; }
        public decimal MerchantCommissionRateAmount { get; set; }
        public decimal MerchantPayoutAmount { get; set; }
        public long SubMerchantMemberId { get; set; }
        public decimal SubMerchantMemberAmount { get; set; }
        public decimal SubMerchantMemberPayoutRate { get; set; }
        public decimal SubMerchantMemberPayoutAmount { get; set; }
        public string TransactionStatus { get; set; }
        public DateTime BlockageResolvedDate { get; set; }
        //public Payout Payout { get; set; }
    }
}
