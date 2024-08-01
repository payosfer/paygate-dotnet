using paygate_dotnet.PayGate.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace paygate_dotnet.PayGate.Responce
{
    public class BasePaymentDto
    {
        public long Id { get; set; }
        public DateTime TranDate { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal WalletAmount { get; set; }
        public string Currency { get; set; }
        public long BuyerMemberId { get; set; }
        public int Installment { get; set; }
        public string RRN { get; set; }
        public string ExternalId { get; set; }
        public int PaymentType { get; set; }
        public string PaymentTypeText { get; set; }
        public int PaymentProvider { get; set; }
        public string PaymentProviderText { get; set; }
        public int PaymentSource { get; set; }
        public string PaymentSourceText { get; set; }
        public int PaymentStatus { get; set; }
        public string PaymentStatusText { get; set; }
        public int Action { get; set; }
        public string ActionText { get; set; }
        public string PaymentDescription { get; set; }
        public bool IsThreeDS { get; set; }
        public decimal MerchantCommissionRate { get; set; }
        public decimal MerchantCommissionRateAmount { get; set; }
        public decimal BankCommissionRate { get; set; }
        public decimal BankCommissionRateAmount { get; set; }
        public bool PaidWithStoredCard { get; set; }
        public string BinNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public string OrderId { get; set; }
        public string CardHolderName { get; set; }
        public string BankCardHolderName { get; set; }
        public string CardNumber { get; set; }
        public int CardType { get; set; }
        public string CardTypeText { get; set; }
        public int CardAssociation { get; set; }
        public string CardAssociationText { get; set; }
        public string CardBrand { get; set; }
        public string RequestedPosAlias { get; set; }
        public long MerchantId { get; set; }
        public long TerminalId { get; set; }
        public string TerminalName { get; set; }
        public string TerminalAlias { get; set; }
        public int TerminalBankCode { get; set; }
        //public MerchantPos Terminal { get; set; }
        public Loyalty Loyalty { get; set; }
        public PaymentError PaymentError { get; set; }
    }
}
