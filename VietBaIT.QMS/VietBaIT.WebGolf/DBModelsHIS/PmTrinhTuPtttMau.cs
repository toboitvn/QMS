using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmTrinhTuPtttMau
    {
        public long MaTrinhTu { get; set; }
        public string TenTrinhTu { get; set; }
        public string TrinhTu { get; set; }
        public string GhiChu { get; set; }
        public string MaLoai { get; set; }
        public string MaKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
    }
}
