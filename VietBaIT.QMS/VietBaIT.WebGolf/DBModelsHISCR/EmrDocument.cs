using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class EmrDocument
    {
        public string LoaiPhieu { get; set; }
        public string MaPhieuHis { get; set; }
        public string TenPhieuHis { get; set; }
        public string MaPhieuEmr { get; set; }
        public string TenPhieuEmr { get; set; }
        public string TenThutuc { get; set; }
        public int? SttHienthi { get; set; }
        public byte? TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string TenBaocao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
