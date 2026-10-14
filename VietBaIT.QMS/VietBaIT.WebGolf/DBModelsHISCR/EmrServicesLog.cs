using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class EmrServicesLog
    {
        public long IdServicesLog { get; set; }
        public long? IdDocumentHis { get; set; }
        public string Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public string EmrNo { get; set; }
        public string PatientCode { get; set; }
        public string UserName { get; set; }
        public string IdPhieu { get; set; }
        public string MaPhieuHis { get; set; }
        public string DepartmentCode { get; set; }
        public string Ghichu { get; set; }
    }
}
