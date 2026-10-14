using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LCountries
    {
        public short CountryId { get; set; }
        public string CounytryCode { get; set; }
        public string CountryName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public bool? HienThi { get; set; }
        public short? IdQuoctich { get; set; }
        public string MaQuoctich { get; set; }
        public string TenQuoctich { get; set; }
    }
}
