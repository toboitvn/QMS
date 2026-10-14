using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuTraDtru
    {
        public int IdPhieuTraDtru { get; set; }
        public DateTime NgayTraDtru { get; set; }
        public short IdNhanVien { get; set; }
        public short? IdKhoa { get; set; }
        public short IdKho { get; set; }
        public bool? DaTra { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiXnhan { get; set; }
        public DateTime? NgayXnhan { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
