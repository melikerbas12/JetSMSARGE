namespace JetSMSARGE.WebAPI.Models
{
    public class SmsRequestDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Msisdns { get; set; }
        public string Messages { get; set; }
        public string TransmissionID { get; set; }
        public string SendDate { get; set; }
        public string Channel { get; set; }
        public string Originator { get; set; }
        public string x { get; set; }
        public string blacklistfilter { get; set; }
        public string iysfilter { get; set; }
        public string iyscode { get; set; }
        public string brandcode { get; set; }
        public string retailercode { get; set; }
        public string recipienttype { get; set; }
        public string SingleResponse { get; set; }
    }
}
