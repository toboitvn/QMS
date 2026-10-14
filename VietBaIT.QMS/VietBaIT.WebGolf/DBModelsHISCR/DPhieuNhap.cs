using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuNhap
    {
        public int IdPhieuNhap { get; set; }
        public string MaPhieuNhap { get; set; }
        public string SoHoaDon { get; set; }
        public DateTime? NgayNhapHdon { get; set; }
        public short? IdKhoNhap { get; set; }
        public short? IdKhoXuat { get; set; }
        public decimal? Vat { get; set; }
        public short? IdNhaCcap { get; set; }
        public string GhiChu { get; set; }
        public string NguoiGiao { get; set; }
        public short? IdNhanVien { get; set; }
        public byte? HienThi { get; set; }
        public byte? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMayTao { get; set; }
        public string IpMaySua { get; set; }
        public decimal? TongTien { get; set; }
        public byte? LoaiPhieu { get; set; }
        public string MaKieuPhieu { get; set; }
        public short? IdNvienXacNhan { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public short? IdKhoaLinh { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public string DiaDiem { get; set; }
        public string KieuThuocVt { get; set; }
        public short? LoaiNhap { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
        public bool? DaChot { get; set; }
        public int? IdThau { get; set; }
        public int? DaDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime? NgayDuyet { get; set; }
    }
}
