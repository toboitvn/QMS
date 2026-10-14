using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LChietkhauNgoaiTinh
    {
        public int IdCkhau { get; set; }
        public string MaCkhau { get; set; }
        public string TenChkhau { get; set; }
        public int? Stt { get; set; }
        public decimal? SoTienCkhau { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MaDtuong { get; set; }
    }
}
