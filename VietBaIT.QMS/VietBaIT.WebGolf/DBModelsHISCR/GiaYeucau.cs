using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class GiaYeucau
    {
        public string Id { get; set; }
        public string MaDvkt { get; set; }
        public string MaAnhxa { get; set; }
        public string TenDvkt { get; set; }
        public string TenBhyt { get; set; }
        public string NhomBv { get; set; }
        public string NhomGuibh { get; set; }
        public decimal? GiaBhyt { get; set; }
        public decimal? PhuthuBhytYc { get; set; }
        public decimal? GiaVienphi { get; set; }
        public decimal? GiaYeucau1 { get; set; }
    }
}
