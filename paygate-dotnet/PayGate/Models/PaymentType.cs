﻿using System.Runtime.Serialization;

namespace paygate_dotnet.PayGate.Models
{ 
    public enum PaymentType
    {
        [EnumMember(Value = "CARD_PAYMENT")] CARD_PAYMENT,

        [EnumMember(Value = "WALLET_PAYMENT")] WALLET_PAYMENT,

        [EnumMember(Value = "CARD_AND_WALLET_PAYMENT")]
        CARD_AND_WALLET_PAYMENT,

        [EnumMember(Value = "DEPOSIT_PAYMENT")]
        DEPOSIT_PAYMENT,
        [EnumMember(Value = "APM")] APM
    }
}
