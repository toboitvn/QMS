using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DNhapXuat
    {
        public long IdChiTiet { get; set; }
        public string MaPhieu { get; set; }
        public short? IdKho { get; set; }
        public int IdThuoc { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? PhuThu { get; set; }
        public int? IdPhieuCt { get; set; }
        public int? IdPhieu { get; set; }
        public int? Vat { get; set; }
        public string SoHoaDon { get; set; }
        public int? IdNhaCcap { get; set; }
        public byte? LoaiPhieu { get; set; }
        public string MaKieuLoaiPhieu { get; set; }
        public DateTime? NgayNhapXuat { get; set; }
        public short? IdNhanVien { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string IpMayTao { get; set; }
        public short? IdKhoaLinh { get; set; }
        public decimal? GiaBan { get; set; }
    }
}
