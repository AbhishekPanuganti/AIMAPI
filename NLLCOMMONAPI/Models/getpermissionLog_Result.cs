
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getpermissionLog_Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
        public string activity { get; set; }
        public string remarks { get; set; }
        public string createdbyname { get; set; }
        public string updatedbyname { get; set; }
        public string historyby { get; set; }
        public Nullable<System.DateTime> historyon { get; set; }
        public string locationname { get; set; }
        public string departmentname { get; set; }
    }
}
