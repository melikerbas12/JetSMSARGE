using JetSMSARGE.WebAPI.Models;

namespace JetSMSARGE.WebAPI.ApiClientServices.JetSMS
{
    public interface IJetSMSApiClient
    {
        public Task<SmsResponseDto> SendSms(SmsRequestDto model);
    }
}