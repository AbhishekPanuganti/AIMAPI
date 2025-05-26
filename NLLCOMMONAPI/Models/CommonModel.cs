using System.Net;

namespace NLLCOMMONAPI.Models
{
    public class CommonModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class LoginResponse
    {
        public string Username { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }

    public class NokeyResult
    {
        public int result { get; set; } = 0;
    }

    public class getSettings_Result
    {
        public int id { get; set; }
        public string gs1code { get; set; } = string.Empty;
        public int createdby { get; set; }
        public System.DateTime createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
        public Nullable<int> extensioncode { get; set; }
        public string formatno { get; set; } = string.Empty;
        public Nullable<int> maxprintcount { get; set; }
    }

    public  class getEmployeeByGlobalID_Result
    {
        public int id { get; set; }
        public string code { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string adid { get; set; } = string.Empty;
        public Nullable<int> userid { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
        public string password { get; set; } = string.Empty;
        public string globalid { get; set; } = string.Empty;
        public Nullable<int> locationid { get; set; }
        public Nullable<int> departmentid { get; set; }
        public Nullable<int> subdepartmentid { get; set; }
        public string managerid { get; set; } = string.Empty;
        public string hodid { get; set; } = string.Empty;
        public string departmentname { get; set; } = string.Empty;
        public string subdepartmentname { get; set; } = string.Empty;
        public string rolename { get; set; } = string.Empty;
        public string locationname { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
    }

    public class Customresponse
    {
        public HttpStatusCode status { get; set; }
        public getEmployeeByGlobalID_Result emp1 { get; set; }
        public string stringresult { get; set; } = string.Empty;
        public List<string> stringresultarray { get; set; }
    }

    public  class SystemlogModel
    {
        public int id { get; set; }
        public int userid { get; set; }
        public string module { get; set; } = string.Empty;
        public string activity { get; set; } = string.Empty;   
        
    }

    public class ExceptionlogModel
    {
        public int id { get; set; }
        public string userid { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string apipath { get; set; } = string.Empty;
        public string exeptiontext { get; set; } = string.Empty;
    }

    public class FileUploadRequest
    {
        public IFormFile? File { get; set;}
    }
}
