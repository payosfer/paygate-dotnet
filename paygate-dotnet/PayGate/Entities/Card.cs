using paygate_dotnet.PayGate.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paygate_dotnet.Models.Entities
{
    public  class Card: CardDto
    {

        public long TerminalId { get; set; }

        public string CardHolderName { get; set; }

        public string CardNumber { get; set; }

        public string ExpireYear { get; set; }

        public string ExpireMonth { get; set; }

        public string Cvc { get; set; }

        public string CardAlias { get; set; }

        public string CardUserKey { get; set; }

        public string CardToken { get; set; }

        public bool SaveCard { get; set; } = false;

        public string BinNumber { get; set; }

        public string LastFourDigits { get; set; }

        public string CardHolderIdentityNumber { get; set; }
    }
}
