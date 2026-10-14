using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDiseases
    {
        public short DiseaseId { get; set; }
        public string DiseaseCode { get; set; }
        public short DiseaseTypeId { get; set; }
        public string DiseaseName { get; set; }
        public string SDesc { get; set; }
        public string FirstChar { get; set; }
        public string ParentId { get; set; }
    }
}
