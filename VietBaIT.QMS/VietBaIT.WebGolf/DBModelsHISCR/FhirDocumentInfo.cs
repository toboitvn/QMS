using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class FhirDocumentInfo
    {
        public long FhirDocumentInfoId { get; set; }
        public long FhirDocumentHisId { get; set; }
        public short? Status { get; set; }
        public string MessageError { get; set; }
        public string ResponseData { get; set; }
        public DateTime? SendTime { get; set; }
        public string Payload { get; set; }
    }
}
