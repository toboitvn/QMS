using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDanhmucIcd9
    {
        public int IdIcd9 { get; set; }
        public string MaIcd9 { get; set; }
        public string TenIcd9 { get; set; }
        public string TenTienganh { get; set; }
        public string MaChuong { get; set; }
        public string TenChuong { get; set; }
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string MaNhomphu { get; set; }
        public string TenNhomphu { get; set; }
        public string GhiChu { get; set; }
        public bool? HienThi { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
