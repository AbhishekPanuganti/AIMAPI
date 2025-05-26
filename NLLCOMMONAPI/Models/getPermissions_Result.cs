
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getPermissions_Result
    {
        public int id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
    }
}
