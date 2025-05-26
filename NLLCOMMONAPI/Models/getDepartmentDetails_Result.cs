
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getDepartmentDetails_Result
    {
        public int Id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpDatedDate { get; set; }
        public Nullable<int> Freezed { get; set; }
    }
}
