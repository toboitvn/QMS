using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LQheLoaibgBenhly
    {
        public int Id { get; set; }
        public int? IdLoaiBg { get; set; }
        public int? IdBenhLy { get; set; }
        public int? IdGoiDvu { get; set; }
        public string TenHienThi { get; set; }
        public decimal? DonGiaGoc { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PthuTrongGoi { get; set; }
        public decimal? PthuNgoaiGoi { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MaDtuong { get; set; }
    }
}
