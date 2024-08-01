using System;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Newtonsoft.Json;
using paygate_dotnet;
using paygate_dotnet.PayGate.Request;

public class PaymentClient
{
    private readonly string _authUrl;
    private readonly string _apiUrl;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _userName;
    private readonly string _password;

    public PaymentClient(string authUrl, string apiUrl, string clientId, string clientSecret, string userName, string password)
    {
        _authUrl = authUrl;
        _apiUrl = apiUrl;
        _clientId = clientId;
        _clientSecret = clientSecret;
        _userName = userName;
        _password = password;
    }

    public async Task<string> CreatePayment(CreatePaymentInput paymentInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(paymentInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/payment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> Cancel(CancelPaymentInput cancelInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(cancelInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/cancel-payment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> Refund(RefundPaymentInput refundInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(refundInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/refund-payment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> Init3DSPayment(CreatePaymentInput paymentInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(paymentInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/init3DSPayment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> Complete3DSPayment(CompleteThreeDSPaymentInput paymentInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(paymentInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/complete3DSPayment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> PreAuthPayment(CreatePaymentInput paymentInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(paymentInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/pre-auth-payment", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }

    public async Task<string> PostAuthPayment(long paymentId,PostAuthPaymentInput paymentInput)
    {
        try
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            using (var client = new HttpClient(handler))
            {
                var tokenResponse = await client.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = _authUrl,
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Scope = "offline_access",
                    UserName = _userName,
                    Password = _password,
                });

                if (tokenResponse.IsError)
                {
                    throw new Exception($"Token error: {tokenResponse.Error}, Error Description: {tokenResponse.ErrorDescription}");
                }

                client.SetBearerToken(tokenResponse.AccessToken);

                var json = JsonConvert.SerializeObject(paymentInput);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiUrl}/api/app/payment/auth-payment/{paymentId}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API error: {response.StatusCode}, Content: {errorContent}");
                }
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"HTTP Request Error: {e.Message}", e);
        }
        catch (JsonException e)
        {
            throw new Exception($"JSON Serialization Error: {e.Message}", e);
        }
        catch (Exception e)
        {
            throw new Exception($"Unexpected Error: {e.Message}", e);
        }
    }
}

