namespace NLLCOMMONAPI.Data.Models.User
{
    public class MUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AuthenticationMode { get; set; }
        public string samAccountName { get; set; }
        public string adid { get; set; }
    }
}
