using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmPhieuPhauThuatThuThuat
    {
        public int IdPhieu { get; set; }
        public int IdPhongMo { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public int? GioLapPhieu { get; set; }
        public int? PhutLapPhieu { get; set; }
        public int? BacSyLamPhieu { get; set; }
        public string ChanDoanTruocMo { get; set; }
        public string ChanDoanSauMo { get; set; }
        public string PhuongPhapPttt { get; set; }
        public string TrinhTuPttt { get; set; }
        public string MaPpvoCam { get; set; }
        public bool? BTaiBien { get; set; }
        public string NguyenNhanTaiBien { get; set; }
        public bool? BTuVong { get; set; }
        public DateTime? NgayGioTuVong { get; set; }
        public string NguyenNhanTuVong { get; set; }
        public bool? TrangThaiHoanThanh { get; set; }
        public byte[] Anh1 { get; set; }
        public byte[] HinhAnhPt { get; set; }
        public string MaChiTieu { get; set; }
        public string ListMaChiTieu { get; set; }
        public string ListMaPpphauThuat { get; set; }
        public bool? TrangThaiPhieu { get; set; }
        public double? TongTien { get; set; }
        public string DanLuu { get; set; }
        public DateTime? NgayRutDl { get; set; }
        public DateTime? NgayRutSondTieu { get; set; }
        public DateTime? NgayCatChi { get; set; }
        public string MaLoaiPt { get; set; }
        public string CachThucPt { get; set; }
        public string MaChuyenKhoa { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }
        public string GhiChu { get; set; }
        public string NhanXet { get; set; }
        public DateTime? NgayGioYlenh { get; set; }
        public string MaNguoiDungKhoa { get; set; }
        public string MaNguoiDungPt { get; set; }
        public int? TrangThaiIn { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
        public string MaIcd9 { get; set; }
        public int? IdThietbi { get; set; }
    }
}
