
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_getTeamDetailsIdeaid_Result
    {
        public int Id { get; set; }
        public string Member { get; set; }
        public Nullable<System.DateTime> Createdon { get; set; }
        public string Createdby { get; set; }
        public Nullable<System.DateTime> Updatedon { get; set; }
        public string Updatedby { get; set; }
        public Nullable<bool> Freezed { get; set; }
        public Nullable<int> IdeaId { get; set; }
        public string membertype { get; set; }
        public string membername { get; set; }
    }
}
