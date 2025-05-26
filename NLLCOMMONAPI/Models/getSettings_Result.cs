
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getSettings_Result
    {
        public int id { get; set; }
        public int minimumideaacceptance { get; set; }
        public string testemail { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> updatedby { get; set; }
        public Nullable<System.DateTime> updatedon { get; set; }
        public bool freezed { get; set; }
        public Nullable<int> maxcollaborators { get; set; }
        public Nullable<int> maxteammembers { get; set; }
    }
}
