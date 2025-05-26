
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getUWRByID_Result
    {
        public int id { get; set; }
        public int userid { get; set; }
        public int roleid { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
        public string remarks { get; set; }
    }
}
