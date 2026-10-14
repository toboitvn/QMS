using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDiseaseTypeBackup
    {
        public short DiseaseTypeId { get; set; }
        public short? ParentDiseaseTypeId { get; set; }
        public string DiseaseTypeCode { get; set; }
        public string DiseaseTypeName { get; set; }
        public string DiseaseTypeNameEn { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public byte? DiseaseType { get; set; }
    }
}
