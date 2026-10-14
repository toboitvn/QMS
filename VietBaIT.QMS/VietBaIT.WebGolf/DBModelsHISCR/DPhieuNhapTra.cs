using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuNhapTra
    {
        public int IdPhieuNhapTra { get; set; }
        public string MaPhieuNhapTra { get; set; }
        public DateTime? NgayNhapTra { get; set; }
        public short? IdNhanVien { get; set; }
        public short? IdKhoTra { get; set; }
        public short? IdKhoaTra { get; set; }
        public short? IdKhoLinh { get; set; }
        public short? IdKhoaThien { get; set; }
        public byte? NhapTraTuTruc { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? IdDonThuoc { get; set; }
        public short? IdNhaCcap { get; set; }
        public int? IdPhieuBn { get; set; }
        public byte? LoaiPhieu { get; set; }
        public string MaLoaiPhieu { get; set; }
        public byte? TrangThai { get; set; }
        public string IpMayTao { get; set; }
        public string IpMaySua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public string LyDo { get; set; }
        public bool? HienThi { get; set; }
        public bool? DaChot { get; set; }
        public DateTime? NgayChot { get; set; }
        public string KieuThuocVt { get; set; }
        public int? IdChot { get; set; }
    }
}
