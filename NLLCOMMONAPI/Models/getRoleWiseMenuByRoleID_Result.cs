
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getRoleWiseMenuByRoleID_Result
    {
        public int id { get; set; }
        public int roleid { get; set; }
        public string rolename { get; set; }
        public string remarks { get; set; }
        public int menuid { get; set; }
        public Nullable<int> permissionid { get; set; }
        public Nullable<int> permissioncode { get; set; }
        public string permissionname { get; set; }
        public string menuname { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public string createdbyname { get; set; }
        public string updatedbyname { get; set; }
    }
}
