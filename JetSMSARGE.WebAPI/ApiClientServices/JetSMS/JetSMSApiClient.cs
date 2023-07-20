using JetSMSARGE.WebAPI.Models;

namespace JetSMSARGE.WebAPI.ApiClientServices.JetSMS
{
    public class JetSMSApiClient : IJetSMSApiClient
    {
        private readonly HttpClient _apiClient;

        public async Task<SmsResponseDto> SendSms(SmsRequestDto model)
        {
            var response = await _apiClient.PostAsJsonAsync(API.JetSMSUrl.SendSMS, model);

            if(response.IsSuccessStatusCode)
                 return await response.Content.ReadFromJsonAsync<SmsResponseDto>();

            return null;
          
        }
    }
}