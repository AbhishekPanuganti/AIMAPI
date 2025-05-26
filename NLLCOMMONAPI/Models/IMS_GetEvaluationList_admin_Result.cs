
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_GetEvaluationList_admin_Result
    {
        public int Id { get; set; }
        public string IdeaId { get; set; }
        public string IdeaCode { get; set; }
        public string IdeaTitle { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string EvaluationStatus { get; set; }
        public Nullable<int> EvaluationStatusCode { get; set; }
        public string Createdon { get; set; }
        public string Createdby { get; set; }
        public string Createdbyname { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string IdeaValueText { get; set; }
        public string locationname { get; set; }
        public string departmentname { get; set; }
        public string selectionremarks { get; set; }
        public string scoringremarks { get; set; }
        public string CCID { get; set; }
        public string CCIDname { get; set; }
    }
}
