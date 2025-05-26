
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getsystemlog_Result
    {
        public int id { get; set; }
        public Nullable<int> userid { get; set; }
        public string module { get; set; }
        public string activity { get; set; }
        public System.DateTime dateandtime { get; set; }
        public string username { get; set; }
        public string adid { get; set; }
    }
}
