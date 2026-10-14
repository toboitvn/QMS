using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TGiayChungsinh
    {
        public int Id { get; set; }
        public int? IdCapphat { get; set; }
        public string MauCt { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public int? IdBenhnhan { get; set; }
        public string MaLuotkham { get; set; }
        public string SoSeri { get; set; }
        public string MaCskcb { get; set; }
        public string HoTenMe { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? DanToc { get; set; }
        public string MaThe { get; set; }
        public string MaSobhxhMe { get; set; }
        public string Cmnd { get; set; }
        public DateTime? NgayCapCmnd { get; set; }
        public string NoiCapCmnd { get; set; }
        public string DiaChi { get; set; }
        public string HoTenCha { get; set; }
        public string TenCon { get; set; }
        public int? GioiTinhCon { get; set; }
        public int? SoCon { get; set; }
        public decimal? CanNangCon { get; set; }
        public DateTime? NgaySinhcon { get; set; }
        public string NoiSinhCon { get; set; }
        public string TinhTrangCon { get; set; }
        public byte? SinhconPhauthuat { get; set; }
        public byte? SinhconDuoi32tuan { get; set; }
        public string GhiChu { get; set; }
        public string NguoiDoDe { get; set; }
        public string NguoiGhiPhieu { get; set; }
        public string NguoiDaiDien { get; set; }
        public DateTime? NgayCt { get; set; }
        public string So { get; set; }
        public string QuyenSo { get; set; }
        public byte? TrangThai { get; set; }
        public string MaLydo { get; set; }
        public string NguoiHuy { get; set; }
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
        public DateTime? NgayHuy { get; set; }
        public string MaTheTam { get; set; }
        public decimal? LanSinh { get; set; }
        public decimal? SoConSong { get; set; }
        public string MaGiayChungsinh { get; set; }
        public string MaDinhdanh { get; set; }
        public DateTime? NgayCap { get; set; }
    }
}
