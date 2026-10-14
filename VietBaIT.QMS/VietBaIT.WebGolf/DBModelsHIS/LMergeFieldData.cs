using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LMergeFieldData
    {
        public short MergeFieldId { get; set; }
        public string MergeFieldCode { get; set; }
        public string MergeFieldName { get; set; }
        public short? MergeFieldSequence { get; set; }
        public string MergeFieldType { get; set; }
        public string MergeFieldNode { get; set; }
    }
}
