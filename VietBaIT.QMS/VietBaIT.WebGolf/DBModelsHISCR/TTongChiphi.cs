using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TTongChiphi
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? IdDvu { get; set; }
        public string TenDvu { get; set; }
        public string Dvt { get; set; }
        public double? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public int? IdPhieu { get; set; }
        public int? IdPhieuCt { get; set; }
        public bool? IsPayment { get; set; }
        public bool PaymentStatus { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayDky { get; set; }
        public int? IdKhoa { get; set; }
        public bool? NoiTru { get; set; }
        public string MaKieuDvu { get; set; }
        public int? IdGoiDvu { get; set; }
        public string MaKieuTtoan { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? TrongGoi { get; set; }
        public short? IdLoaiDvu { get; set; }
        public int? SoPhieuRavien { get; set; }
        public int? PaymentId { get; set; }
        public int? DaThien { get; set; }
        public string TenHienThi { get; set; }
        public byte? HienThi { get; set; }
        public short? IdBsyCdinh { get; set; }
        public short? IdKhoaCdinh { get; set; }
        public decimal? TienBnTra { get; set; }
        public decimal? Bnct { get; set; }
        public decimal? Bhct { get; set; }
        public int? XacNhan { get; set; }
        public long? IdThe { get; set; }
        public decimal? PtramBhytGoc { get; set; }
        public decimal? MucHuong { get; set; }
        public decimal? TyleTt { get; set; }
        public decimal? TNguonkhac { get; set; }
        public decimal? THotro { get; set; }
        public byte? ThanhtoanNguonkhac { get; set; }
        public string MaCsKcbThuchien { get; set; }
        public decimal? DongiaBhyt { get; set; }
    }
}
