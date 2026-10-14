using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LNhomBenhYhct
    {
        public short DiseaseTypeId { get; set; }
        public string DiseaseTypeCode { get; set; }
        public string DiseaseTypeName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public bool? HienThi { get; set; }
    }
}
