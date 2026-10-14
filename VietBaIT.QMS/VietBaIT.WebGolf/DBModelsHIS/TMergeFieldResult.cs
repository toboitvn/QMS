using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TMergeFieldResult
    {
        public long MergeFieldResultId { get; set; }
        public string MergeFieldResultDetail { get; set; }
        public long AssignDetailId { get; set; }
        public string MergeFieldCode { get; set; }
        public DateTime MergeFieldResultCreatedDate { get; set; }
        public string MergeFieldResultCreatedBy { get; set; }
        public int? FormId { get; set; }
        public string FormType { get; set; }
        public string PatientCode { get; set; }
    }
}
