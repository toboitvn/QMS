using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TNghiomBhxh
    {
        public long IdNghiom { get; set; }
        public long IdCapphat { get; set; }
        public string MauNghiom { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string Serie { get; set; }
        public long IdBenhnhan { get; set; }
        public string MaLuotkham { get; set; }
        public string DonviLamviec { get; set; }
        public string ChandoanPpdt { get; set; }
        public DateTime NghiTungay { get; set; }
        public DateTime NghiDenngay { get; set; }
        public decimal NghiSongay { get; set; }
        public string HotenCha { get; set; }
        public string HotenMe { get; set; }
        public short? IdNhanvien { get; set; }
        public short? BacsyKhambenh { get; set; }
        public short? TrangThai { get; set; }
        public string MaLydo { get; set; }
        public string NguoiHuy { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayCapphat { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayIn { get; set; }
        public string IpMaytao { get; set; }
        public string IpMaysua { get; set; }
        public int? LanIn { get; set; }
        public string NguoiIn { get; set; }
        public short? DaGui { get; set; }
        public string ThutruongDv { get; set; }
        public string SoCt { get; set; }
        public string SoKcb { get; set; }
        public string MaBhxh { get; set; }
        public string MaTheTam { get; set; }
        public int? MaDinhChiThai { get; set; }
        public string NguyennhanDinhchi { get; set; }
        public DateTime? ThoigianDinhchi { get; set; }
        public decimal? TuoiThai { get; set; }
    }
}
