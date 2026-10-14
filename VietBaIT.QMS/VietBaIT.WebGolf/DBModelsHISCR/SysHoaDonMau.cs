using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysHoaDonMau
    {
        public int Id { get; set; }
        public string MauHdon { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string SerieHtai { get; set; }
        public string MaCoSo { get; set; }
        public bool? KhoaLai { get; set; }
        public decimal? HdonMauId { get; set; }
    }
}
