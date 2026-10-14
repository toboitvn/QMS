using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewThongtinBenhly
    {
        public int IdBenhLy { get; set; }
        public string MaBenhLy { get; set; }
        public string TenBenhLy { get; set; }
        public int? ThuTu { get; set; }
        public string MaDtuong { get; set; }
        public int? IdGoiDvu { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public decimal? DonGiaBly { get; set; }
        public string MaDtuongApDung { get; set; }
        public string TenGoiDvu { get; set; }
        public int? SoNgayNam { get; set; }
        public decimal? DonGia { get; set; }
    }
}
