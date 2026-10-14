using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LInsuranceObjects
    {
        public short InsObjectId { get; set; }
        public string InsObjectCode { get; set; }
        public string InsObjectName { get; set; }
        public short? InsuranceGroupId { get; set; }
        public short? ObjectTypeId { get; set; }
        public decimal? Percent { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public string SoBhyt { get; set; }
        public string SoQloi { get; set; }
        public bool? IsEpDungTuyen { get; set; }
    }
}
