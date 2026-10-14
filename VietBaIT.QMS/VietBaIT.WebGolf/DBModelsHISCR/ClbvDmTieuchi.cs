using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ClbvDmTieuchi
    {
        public string MaTieuchi { get; set; }
        public string MaTieuchiCha { get; set; }
        public string TenTieuchi { get; set; }
        public int RankOrder { get; set; }
        public int DiemSo { get; set; }
        public decimal? HeSo { get; set; }
        public int? IdMucDanhgia { get; set; }
    }
}
