using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TNoitietPhieuDctAo
    {
        public int IdPhieuDct { get; set; }
        public string MaPhieuDct { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public decimal? TienGoc { get; set; }
        public decimal? TienBhct { get; set; }
        public decimal? TienBnct { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public byte? KieuThanhtoan { get; set; }
        public string MaKhoaThien { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
