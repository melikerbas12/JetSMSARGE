namespace JetSMSARGE.WebAPI.Models
{
    public class SmsResponseDto
    {
        public int Status { get; set; }
        public int[] MessageIDs { get; set; }
    }
}
