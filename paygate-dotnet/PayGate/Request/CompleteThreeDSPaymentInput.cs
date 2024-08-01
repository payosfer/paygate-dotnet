using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.PayGate.Request
{
    public  class CompleteThreeDSPaymentInput
    {
        //VAKIF ve ortak parametreler
        public long? PaymentId { get; set; }

        public string MerchantId { get; set; }

        public string Pan { get; set; }

        public string Expiry { get; set; }

        public string PurchAmount { get; set; }

        public string PurchCurrency { get; set; }

        public string VerifyEnrollmentRequestId { get; set; }

        public string Xid { get; set; }

        public string SessionInfo { get; set; }

        public string Status { get; set; }

        public string Cavv { get; set; }

        public string Eci { get; set; }

        public string ExpSign { get; set; }

        public string InstallmentCount { get; set; }

        public string SubMerchantNo { get; set; }

        public string SubMerchantNumber { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }


        //YKB
        public string Amount { get; set; }

        public string BankPacket { get; set; }

        //public string Xid { get; set; }

        //QNB
        public string AuthCode { get; set; }

        public string OrderId { get; set; }

        public string ProcReturnCode { get; set; }

        public string ErrMsg { get; set; }

        //Paratika
        public string responseMsg { get; set; }

        public string responseCode { get; set; }

        //public string errorCode { get; set; }

        public string pgTranErrorText { get; set; }

        public string pgTranId { get; set; }

        public string merchantPaymentId { get; set; }

        //Garanti
        public string oid { get; set; }

        //public string cavv { get; set; }

        //public string eci { get; set; }

        //public string xid { get; set; }

        public string md { get; set; }

        public string mdStatus { get; set; }

        public string txnInstallmentCount { get; set; }

        public string txnAmount { get; set; }

        public string txnCurrencyCode { get; set; }

        public string CustomerIPAddress { get; set; }

        public string customerEmailAddress { get; set; }

        //Denizbank
        public string TransId { get; set; }

        //public string OrderId { get; set; }

        //public string ProcReturnCode { get; set; }

        //public string ErrorMessage { get; set; }
    }
}
