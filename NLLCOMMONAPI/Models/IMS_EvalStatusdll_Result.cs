
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_EvalStatusdll_Result
    {
        public int Id { get; set; }
        public string EvaluationStatus { get; set; }
        public Nullable<System.DateTime> Createdon { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updatedon { get; set; }
        public string Updatedby { get; set; }
        public bool Freezed { get; set; }
        public int code { get; set; }
    }
}
