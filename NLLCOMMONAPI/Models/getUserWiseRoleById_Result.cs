
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getUserWiseRoleById_Result
    {
        public int id { get; set; }
        public int roleid { get; set; }
        public string rolename { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        public string globalid { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public string createdbyname { get; set; }
        public string updatedbyname { get; set; }
    }
}
