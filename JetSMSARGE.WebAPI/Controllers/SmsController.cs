using JetSMSARGE.WebAPI.ApiClientServices.JetSMS;
using JetSMSARGE.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JetSMSARGE.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SmsController : ControllerBase
{
    IJetSMSApiClient _apiClient;
    public SmsController(IJetSMSApiClient apiClient)
    {
        _apiClient = apiClient;
    }
    [HttpPost]
    public async Task<IActionResult> Post(SmsRequestDto model, CancellationToken cancellationToken)
    {
        var result = await _apiClient.SendSms(model);
        return Ok(result);
    }
}
