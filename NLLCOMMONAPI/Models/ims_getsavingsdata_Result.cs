
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class ims_getsavingsdata_Result
    {
        public int Id { get; set; }
        public string IdeaCode { get; set; }
        public Nullable<decimal> actualTwelveMonthsSavings { get; set; }
        public Nullable<decimal> incentiveearned { get; set; }
    }
}
