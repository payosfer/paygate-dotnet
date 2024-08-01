<p align="center">
  <img src="https://github.com/esrayildiizz/Example/assets/106755194/e0197438-b265-449a-a90b-cf4f526a0e01" alt="PAYGATE Image"/>
</p>

<p align="center">
<strong>PAYGATE</strong>
</p>

<p align="center">
PayGate ile tüm online ödemelerinizi tek merkezden yönetin 
</p>
<p align="center">
katma değerli servislerimiz ile ödeme giderlerinizi azaltın, cironuzu artırın ve işletmenizi büyütün.
</p>

## PAYGATE
[![Paygate Dotnet CI](https://img.shields.io/badge/Paygate%20Dotnet%20CI-passing-brightgreen)]()
[![nuget](https://img.shields.io/badge/nuget-v1.0.61-blue)]()


## Gereksinimler
- .NET Standart 2.0
- .NET Core 8 (Tests ve Web projeleri için)

## Kurulum
`Install-Package  ...... `



## Kullanım
PayGate API'sine erişmek için öncelikle API kimlik bilgilerini (örneğin bir API anahtarı ve gizli anahtar) edinmeniz gerekir. 
PayGate hesabınız yoksa https://dashboard.payosfer.com/ adresinden kayıt olabilirsiniz.
API kimlik bilgilerinizi aldıktan sonra, PayGate kimlik bilgilerinizle bir örnek oluşturarak PayGate'i kullanmaya başlayabilirsiniz.

```csharp
PaymentClient paymentService = new PaymentClient(authUrl, apiUrl, clientId, clientSecret);
```

Test için gereken url adreslerine dökumandan(grav) ulaşabilirsiniz.

## Örnekler

### Ödeme(Non-3D) Kullanım Örneği

```csharp

var paymentService = new PaymentService(authUrl, apiUrl, clientId, clientSecret);

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
        CardNumber = "1111111111111111",
        ExpireYear = "1111",
        ExpireMonth = "11",
        Cvc = "111"
    },
};

try
{
    var result = await paymentService.CreatePayment(paymentInput);
    Console.WriteLine("Başarılı! Yanıt: " + result);
}
catch (Exception ex)
{
    Console.WriteLine("Hata oluştu: " + ex.Message);
}
```


### Katkılar
For all contributions to this client please see the contribution guide here.

## Lisans

*MIT*
![image](https://github.com/user-attachments/assets/e7ae6194-0137-4e2e-85f6-37a307024602)
