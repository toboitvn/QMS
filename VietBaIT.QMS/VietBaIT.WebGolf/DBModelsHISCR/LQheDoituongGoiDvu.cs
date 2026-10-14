using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LQheDoituongGoiDvu
    {
        public int Id { get; set; }
        public string MaGoiDvu { get; set; }
        public string MaDtuong { get; set; }
        public int? SoLuong { get; set; }
        public decimal? GiaDtuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public int IdDvu { get; set; }
        public int IdLoaiDvu { get; set; }
        public string TenDvu { get; set; }
        public string TenLoaiDvu { get; set; }
        public string MaKieuDvu { get; set; }
        public int? IdGoiDvu { get; set; }
        public string KieuThue { get; set; }
    }
}
