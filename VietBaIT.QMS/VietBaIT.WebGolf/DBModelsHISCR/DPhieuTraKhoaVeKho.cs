using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuTraKhoaVeKho
    {
        public int IdPhieuTraKho { get; set; }
        public DateTime? NgayTra { get; set; }
        public short? IdNhanVien { get; set; }
        public short? IdKhoNhan { get; set; }
        public short? IdKhoaTra { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public bool? DaTra { get; set; }
        public string GhiChu { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
        public bool? DaChot { get; set; }
    }
}
