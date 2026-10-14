using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DPhieuKhoaKe
    {
        public int IdPhieuKhoaKe { get; set; }
        public DateTime NgayKhoaKe { get; set; }
        public short IdKho { get; set; }
        public short IdNhanVien { get; set; }
        public short IdKhoa { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool XacNhan { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public bool? HienThi { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
        public bool? DaChot { get; set; }
    }
}
