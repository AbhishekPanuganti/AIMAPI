
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_GetIMSEvaluationList_Result
    {
        public int Id { get; set; }
        public string IdeaCode { get; set; }
        public string IdeaTitle { get; set; }
        public string Description { get; set; }
        public string EvaluationStatus { get; set; }
        public string IdeaValueText { get; set; }
    }
}
