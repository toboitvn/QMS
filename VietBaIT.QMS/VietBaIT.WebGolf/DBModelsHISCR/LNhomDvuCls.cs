using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LNhomDvuCls
    {
        public int IdNhomcls { get; set; }
        public string MaNhomcls { get; set; }
        public string TenNhomcls { get; set; }
        public int? IdLoaiDvu { get; set; }
        public int? IdDvu { get; set; }
        public int? IdNhomCha { get; set; }
        public string MaDtuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int? SoThuTu { get; set; }
        public int? SoLuong { get; set; }
        public string MaKhoaThien { get; set; }
        public bool? IsPublic { get; set; }
    }
}
