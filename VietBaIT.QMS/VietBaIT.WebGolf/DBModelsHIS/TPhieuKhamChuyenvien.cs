using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuKhamChuyenvien
    {
        public int IdPhieuChuyenvien { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime NgayChuyenVien { get; set; }
        public short? IdBenhVienCden { get; set; }
        public string DauHieuCls { get; set; }
        public string CacXetNghiem { get; set; }
        public string ChuanDoan { get; set; }
        public string ThuocDaDung { get; set; }
        public string TtrangBnLucCvien { get; set; }
        public string LyDoChuyen { get; set; }
        public string HuongDieuTri { get; set; }
        public string PhuongTienChuyen { get; set; }
        public string HotenChucdanhNgchuyen { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string MayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string SoChuyenVien { get; set; }
        public string MaySua { get; set; }
        public bool? NoiTru { get; set; }
        public string MaCsKcb { get; set; }
    }
}
