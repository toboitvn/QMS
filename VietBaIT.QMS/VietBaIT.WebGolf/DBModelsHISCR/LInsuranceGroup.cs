using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LInsuranceGroup
    {
        public short InsuranceGroupId { get; set; }
        public string InsuranceName { get; set; }
        public string InsuranceCode { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
    }
}
