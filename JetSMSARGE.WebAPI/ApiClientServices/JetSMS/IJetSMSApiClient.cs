using JetSMSARGE.WebAPI.Models;

namespace JetSMSARGE.WebAPI.ApiClientServices.JetSMS
{
    public interface IJetSMSApiClient
    {
        public Task<string> SendSms(SmsRequestDto model);
    }
}