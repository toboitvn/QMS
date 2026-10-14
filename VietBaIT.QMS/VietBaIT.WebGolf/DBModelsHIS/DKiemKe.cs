using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DKiemKe
    {
        public int IdkiemKe { get; set; }
        public DateTime NgayKiemKe { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public short IdKho { get; set; }
        public short IdNhanVien { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string GhiChu { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string ToKiemKe { get; set; }
        public string ToKiemKe1 { get; set; }
        public string ToKiemKe2 { get; set; }
        public string ChucDanhToKiemKe { get; set; }
        public string ChucDanhToKiemKe1 { get; set; }
        public string ChucDanhToKiemKe2 { get; set; }
        public string NoiKiemKe { get; set; }
        public string KetQuaKiemKe { get; set; }
        public string YKienDeXuat { get; set; }

        public virtual DKho IdKhoNavigation { get; set; }
    }
}
