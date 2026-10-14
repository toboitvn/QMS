using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuCapphatBackup
    {
        public int IdCapphat { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public short IdKhoaLinh { get; set; }
        public short IdKhoXuat { get; set; }
        public short IdNvien { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime? NgayXacnhan { get; set; }
        public string NguoiXacnhan { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool DaCapPhat { get; set; }
        public string MotaThem { get; set; }
        public string LoaiPhieu { get; set; }
        public bool? LinhBsung { get; set; }
        public string MaDoiTuong { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
        public bool? HienThi { get; set; }
    }
}
