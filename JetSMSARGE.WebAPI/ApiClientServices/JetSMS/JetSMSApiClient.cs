using JetSMSARGE.WebAPI.Models;

namespace JetSMSARGE.WebAPI.ApiClientServices.JetSMS
{
    public class JetSMSApiClient : IJetSMSApiClient
    {
        private readonly HttpClient _apiClient;
        public JetSMSApiClient(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<string> SendSms(SmsRequestDto model)
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "Username", model.Username },
                    { "Password", model.Password },
                    { "Msisdns", model.Msisdns },
                    { "Messages", model.Messages },
                    // { "Originator", model.Originator },
                    // { "SendDate", model.SendDate },
                    { "TransmissionID", model.TransmissionID },
                    // { "Channel", model.Channel },
                    // { "x", model.x },
                    // { "blacklistfilter", model.blacklistfilter },
                    // { "iysfilter", model.iysfilter },
                    // { "iyscode", model.iyscode },
                    // { "brandcode", model.brandcode },
                    // { "retailercode", model.retailercode },
                    // { "recipienttype", model.recipienttype },
                    // { "SingleResponse", model.SingleResponse }
                });

            var response = await _apiClient.PostAsync(API.JetSMSUrl.SendSMS, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return await response.Content.ReadAsStringAsync();
            }

            return string.Empty;

        }
    }
}