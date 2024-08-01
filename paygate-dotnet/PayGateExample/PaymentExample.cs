
using paygate_dotnet.Models.Entities;
using System;
using System.Threading.Tasks;
using paygate_dotnet.PayGate.Models;
using paygate_dotnet.PayGate.Request;
using NUnit.Framework;

[TestFixture]
public class PaymentTests
{
    private PaymentClient paymentService;

    // Her testten önce çalışacak olan Setup metodu.
    [SetUp]
    public void Setup()
    {
        var authUrl = "https://localhost:7600/connect/token";
        var apiUrl = "https://localhost:7004";
        var clientId = "CastleService_Swagger";
        var clientSecret = "1q2w3e*";
        var userName = "Ali";
        var password = "Aa7208668*";

        paymentService = new PaymentClient(authUrl, apiUrl, clientId, clientSecret, userName, password);
    }

    // NON-3D Payment
    [Test]
    public async Task CreatePayment()
    {
        var paymentInput = new CreatePaymentInput
        {
            TerminalId = 1,
            MerchantId = 1,
            Amount = new decimal(100.0),
            PaidAmount = new decimal(100.0),
            WalletAmount = new decimal(0.0),
            Installment = 1,
            Currency = Currency.TRY,
            Card = new Card
            {
                CardHolderName = "Haluk Demir",
                CardNumber = "5258640000000001",
                ExpireYear = "2044",
                ExpireMonth = "07",
                Cvc = "000"
            },
        };

        try
        {
            var result = await paymentService.CreatePayment(paymentInput);
            if (result != null)
            {
                Console.WriteLine("Başarılı! Yanıt: " + result);
            }
            else
            {
                Console.WriteLine("Hata: Sonuç null.");
                Assert.Fail("Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("Hata oluştu: " + ex.Message); 
        }
    }

    // Cancel
    [Test]
    public async Task Cancel()
    {
        var cancelInput = new CancelPaymentInput
        {
            TerminalId = 1,
            PaymentId = 1,
            RRN = "",
            ChargeFromMe = true,
            RefundDestinationType = RefundDestinationType.CARD,
            CancelDescription = "",
            EmailAddress = "",
        };

        try
        {
            var result = await paymentService.Cancel(cancelInput);
            if (result != null)
            {
                Console.WriteLine("Başarılı! Yanıt: " + result);
            }
            else
            {
                Console.WriteLine("Hata: Sonuç null.");
                Assert.Fail("Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("Hata oluştu: " + ex.Message);
        }
    }

    // Refund
    [Test]
    public async Task Refund()
    {
        var refundInput = new RefundPaymentInput
        {
            TerminalId = 1,
            PaymentId = 1,
            RefundAmount = new decimal(100.0),
            RRN = "",
            ChargeFromMe = true,
            RefundDestinationType = RefundDestinationType.CARD,
            RefundDescription = "",
            EmailAddress = "",
        };

        try
        {
            var result = await paymentService.Refund(refundInput);
            if (result != null)
            {
                Console.WriteLine("Başarılı! Yanıt: " + result);
            }
            else
            {
                Console.WriteLine("Hata: Sonuç null.");
                Assert.Fail("Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("Hata oluştu: " + ex.Message);
        }
    }


    // 3D Payment Init
    [Test]
    public async Task Init3DSPayment()
    {

        var paymentInput3D = new CreatePaymentInput
        {
            TerminalId = 1,
            MerchantId = 1,
            Amount = new decimal(100.0),
            PaidAmount = new decimal(100.0),
            WalletAmount = new decimal(0.0),
            Installment = 1,
            Currency = Currency.TRY,
            Card = new Card
            {
                CardHolderName = "Haluk Demir",
                CardNumber = "5258640000000001",
                ExpireYear = "2044",
                ExpireMonth = "07",
                Cvc = "000"
            },
            //Is3D = true, 
            //CallbackUrl = "https://your-callback-url.com" // 3D secure callback URL'niz
        };


        try
        {
            var result3D = await paymentService.CreatePayment(paymentInput3D);
            if (result3D != null)
            {
                Console.WriteLine("3D Secure Başarılı! Yanıt: " + result3D);
            }
            else
            {
                Console.WriteLine("3D Secure Hata: Sonuç null.");
                Assert.Fail("3D Secure Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("3D Secure Hata oluştu: " + ex.Message); // Hata oluşursa testi başarısız olarak işaretle
        }
    }
     
    // 3D Payment Complete
    [Test]
    public async Task Complete3DSPayment()
    {
        var paymentInput3D = new CompleteThreeDSPaymentInput
        {
            
            MerchantId = "1",
        };

        try
        {
            var result3D = await paymentService.Complete3DSPayment(paymentInput3D);
            if (result3D != null)
            {
                Console.WriteLine("3D Secure Başarılı! Yanıt: " + result3D);
            }
            else
            {
                Console.WriteLine("3D Secure Hata: Sonuç null.");
                Assert.Fail("3D Secure Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("3D Secure Hata oluştu: " + ex.Message); // Hata oluşursa testi başarısız olarak işaretle
        }
    }

    // Pre-Auth Payment
    [Test]
    public async Task PreAuthPayment()
    {
        var paymentInput = new CreatePaymentInput  
        {
            TerminalId = 1,
            MerchantId = 1,
            Amount = new decimal(100.0),
            PaidAmount = new decimal(100.0),
            WalletAmount = new decimal(0.0),
            Installment = 1,
            Currency = Currency.TRY,
            Card = new Card
            {
                CardHolderName = "Haluk Demir",
                CardNumber = "5258640000000001",
                ExpireYear = "2044",
                ExpireMonth = "07",
                Cvc = "000"
            },
            Action = PaymentAction.PRE_AUTH,
        };

        try
        {
            var result = await paymentService.PreAuthPayment(paymentInput);
            if (result != null)
            {
                Console.WriteLine("Başarılı! Yanıt: " + result);
            }
            else
            {
                Console.WriteLine("Hata: Sonuç null.");
                Assert.Fail("Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("Hata oluştu: " + ex.Message);
        }
    }

    // Post-Auth Payment
    [Test]
    public async Task PostAuthPayment()
    {

        long paymentId = 1;
        var paymentInput = new PostAuthPaymentInput
        {
            PaidAmount = new decimal(100.0)
        };

        try
        {
            var result = await paymentService.PostAuthPayment(paymentId,paymentInput);
            if (result != null)
            {
                Console.WriteLine("Başarılı! Yanıt: " + result);
            }
            else
            {
                Console.WriteLine("Hata: Sonuç null.");
                Assert.Fail("Sonuç null.");
            }
        }
        catch (Exception ex)
        {
            Assert.Fail("Hata oluştu: " + ex.Message);
        }
    }
}
