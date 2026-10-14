using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDanhmucThem
    {
        public int IdDvu { get; set; }
        public string MaKieuDvu { get; set; }
        public string MaDtuong { get; set; }
        public string TenDvu { get; set; }
        public int? IdKhoa { get; set; }
        public int? IdPhong { get; set; }
        public int? IdGiuong { get; set; }
        public decimal? DonGia { get; set; }
        public int? DonVi { get; set; }
        public decimal? PhuThu { get; set; }
    }
}
