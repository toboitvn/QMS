using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LMergeFieldVungKs
    {
        public int MergeFieldVungKsId { get; set; }
        public string MergeFieldCode { get; set; }
        public int FormId { get; set; }
        public string MergeFieldVungKsDetail { get; set; }
        public bool? IsBold { get; set; }
    }
}
