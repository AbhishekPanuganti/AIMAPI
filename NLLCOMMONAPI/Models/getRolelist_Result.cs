
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getRolelist_Result
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public string remarks { get; set; }
        public string createdbyname { get; set; }
        public string updatedbyname { get; set; }
    }
}
