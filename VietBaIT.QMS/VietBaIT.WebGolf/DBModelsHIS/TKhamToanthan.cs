using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TKhamToanthan
    {
        public int IdKtoanThan { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public int? IdPhieuVaovien { get; set; }
        public int? Mach { get; set; }
        public decimal? NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public int? NhipTho { get; set; }
        public decimal? CanNang { get; set; }
        public decimal? ChieuCao { get; set; }
        public string DaNmac { get; set; }
        public string KhamThoan { get; set; }
        public string KhamHhap { get; set; }
        public string KhamBphanKhac { get; set; }
        public int? IdHsPhaThai { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
    }
}
