using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuDtru
    {
        public int IdPhieuDtru { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public short IdKhoNhap { get; set; }
        public short IdKhoa { get; set; }
        public short? IdNhanVien { get; set; }
        public bool DaXnhan { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiXnhan { get; set; }
        public DateTime? NgayXnhan { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public short? LoaiDtru { get; set; }
        public int? IdNhaCc { get; set; }
        public string GhiChu { get; set; }
        public int? IdLoaiThuoc { get; set; }
    }
}
