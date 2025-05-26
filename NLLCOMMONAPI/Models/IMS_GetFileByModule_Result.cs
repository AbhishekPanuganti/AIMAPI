
namespace NLLCOMMONAPI
{
    using System;
    
    public partial class IMS_GetFileByModule_Result
    {
        public string FileName { get; set; }
        public Nullable<int> FileLength { get; set; }
        public string FileType { get; set; }
        public string Base64string { get; set; }
    }
}
