using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TTongKetBenhAn
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Ldvv { get; set; }
        public string ChanDoan { get; set; }
        public string KhoaDtri { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public DateTime? NgayRv { get; set; }
        public int? SoNgayDtri { get; set; }
        public string HuongDtri { get; set; }
        public string TtrangHienTai { get; set; }
        public string LamSang { get; set; }
        public string CanLamSang { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgaySinhcon { get; set; }
        public DateTime? NgayChetcon { get; set; }
        public int? TtRavien { get; set; }
        public string GhiChu { get; set; }
        public string PpDieutri { get; set; }
        public DateTime? NgayCt { get; set; }
    }
}
