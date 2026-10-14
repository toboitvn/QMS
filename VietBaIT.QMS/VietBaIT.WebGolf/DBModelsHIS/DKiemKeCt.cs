using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DKiemKeCt
    {
        public int IdkiemKeCt { get; set; }
        public int IdkiemKe { get; set; }
        public int IdThuoc { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuongKiemKe { get; set; }
        public double SoLuongThucTe { get; set; }
        public double SoLuongHongVo { get; set; }
        public string GhiChu { get; set; }
        public int IdThuocKho { get; set; }

        public virtual LDrugs IdThuocNavigation { get; set; }
    }
}
