
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_GetIMSList_Result
    {
        public int Id { get; set; }
        public string IdeaCode { get; set; }
        public string IdeaTitle { get; set; }
        public string Description { get; set; }
        public string EvaluationStatus { get; set; }
        public Nullable<int> EvaluationStatusCode { get; set; }
        public string ProcessingStatus { get; set; }
        public string Createdon { get; set; }
        public string Createdby { get; set; }
        public string Updatedon { get; set; }
        public string Updatedby { get; set; }
        public string CategoryName { get; set; }
        public string IdeaValueText { get; set; }
    }
}
