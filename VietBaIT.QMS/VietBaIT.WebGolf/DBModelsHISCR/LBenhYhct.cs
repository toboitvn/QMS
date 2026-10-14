using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LBenhYhct
    {
        public short DiseaseId { get; set; }
        public short DiseaseTypeId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseName { get; set; }
        public string MaIcd10 { get; set; }
        public string TenBhyt { get; set; }
        public string SDesc { get; set; }
        public string FirstChar { get; set; }
        public bool? HienThi { get; set; }
    }
}
