using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class GoiQuanly
    {
        public int IdQly { get; set; }
        public int IdGoiDvu { get; set; }
        public int PatientId { get; set; }
        public DateTime? HieuLucTuNgay { get; set; }
        public DateTime? HieuLucDenNgay { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public bool DaThanhToan { get; set; }
        public bool DaKichHoat { get; set; }
        public string SoLo { get; set; }
        public decimal? TienGoi { get; set; }
        public decimal? MienGiam { get; set; }
        public decimal? GiamtruBhyt { get; set; }
        public DateTime? NgayKichHoat { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThaiHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string NguoiHuy { get; set; }
        public string LydoHuy { get; set; }
        public int? DaKetThuc { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
