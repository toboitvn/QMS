using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class KskDmucHopdong
    {
        public long IdHopDong { get; set; }
        public long IdKhachHang { get; set; }
        public string NguoiDaiDien { get; set; }
        public string SoHopDong { get; set; }
        public DateTime? NgayHopDong { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Tongtien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
