namespace NLLCOMMONAPI.Data.Models.User
{
    public class UserLoginResult
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string adid { get; set; }
        public int? userid { get; set; }
        public int? createdby { get; set; }
        public DateTime? createdon { get; set; }
        public int? updatedby { get; set; }
        public DateTime? updatedon { get; set; }
        public bool freezed { get; set; }
        public string password { get; set; }
        public string globalid { get; set; }
        public int? locationid { get; set; }
        public int? departmentid { get; set; }
        public int? subdepartmentid { get; set; }
        public string managerid { get; set; }
        public string hodid { get; set; }
        public string departmentname { get; set; }
        public string subdepartmentname { get; set; }
        public string rolename { get; set; }
        public string rolecode { get; set; }
        public string locationname { get; set; }
        public string token { get; set; }
    }
}
