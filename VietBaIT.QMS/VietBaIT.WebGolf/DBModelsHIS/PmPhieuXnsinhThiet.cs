using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmPhieuXnsinhThiet
    {
        public long IdPhieu { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdPhongMo { get; set; }
        public string LaySinhThietOdau { get; set; }
        public string CoDinhBangDdbouin { get; set; }
        public DateTime? CoDinhHoi { get; set; }
        public string TomTatBenhSu { get; set; }
        public string PhuongPhapDtdaDung { get; set; }
        public string NhanXet { get; set; }
        public string DaDiLamSinhThiet { get; set; }
        public string ChanDoanTamThoi { get; set; }
        public DateTime? NgayDenKhoaCpbi { get; set; }
        public DateTime? NgayTraLaiKhoaLs { get; set; }
        public string ChuNhiemKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
        public int? AssignIdYc { get; set; }
        public string YeuCauXn { get; set; }
        public bool? CapCuu { get; set; }
    }
}
