using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class FhirDocumentHis
    {
        public long FhirDocumentHisId { get; set; }
        public string ResourceType { get; set; }
        public string Spexecute { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Params { get; set; }
        public short? Status { get; set; }
        public short? ErrorCount { get; set; }
        public string FhirId { get; set; }
        public bool? IsCancel { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? CreatorId { get; set; }
        public string IpMayTao { get; set; }
        public string Note { get; set; }
    }
}
