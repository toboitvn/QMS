using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuNhapCt
    {
        public int IdPhieuNhapCt { get; set; }
        public int IdPhieuNhap { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int IdThuoc { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? GiaBhyt { get; set; }
        public decimal? PhuThu { get; set; }
        public short ThangDu { get; set; }
        public double SoLuong { get; set; }
        public string SoLo { get; set; }
        public int? ChietKhau { get; set; }
        public decimal? ThanhTien { get; set; }
        public string MaPhieuXuat { get; set; }
        public int? IdPhieuXuat { get; set; }
        public string GhiChu { get; set; }
        public decimal? Vat { get; set; }
        public bool? TuTuc { get; set; }
        public short? IdSoQdinh { get; set; }
        public string SttQdinh { get; set; }
        public int? IdThuocKho { get; set; }
        public int? IdThuocKhoChuyen { get; set; }
        public bool? ThuocChia { get; set; }
        public double? SoLuongChia { get; set; }
        public string MaSoDky { get; set; }
        public double? SoLuongDeNghi { get; set; }
        public short? ChatLuong { get; set; }
        public int? IdThauCt { get; set; }
        public decimal? DonGiaTruocVat { get; set; }
        public long? PresdetailId { get; set; }
    }
}
