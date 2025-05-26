
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class getusermenu_Result
    {
        public Nullable<int> id { get; set; }
        public string name { get; set; }
        public string menuicon { get; set; }
        public string menuurl { get; set; }
        public Nullable<int> parentid { get; set; }
        public string rolename { get; set; }
        public string permission { get; set; }
    }
}
