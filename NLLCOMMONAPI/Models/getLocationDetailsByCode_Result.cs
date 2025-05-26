
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getLocationDetailsByCode_Result
    {
        public int Id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpDatedDate { get; set; }
        public Nullable<int> Freezed { get; set; }
        public string addressline1 { get; set; }
        public string addressline2 { get; set; }
        public string addressline3 { get; set; }
        public string addressline4 { get; set; }
        public string licencenumber { get; set; }
        public string serverprinterip { get; set; }
        public string localprinterip { get; set; }
    }
}
