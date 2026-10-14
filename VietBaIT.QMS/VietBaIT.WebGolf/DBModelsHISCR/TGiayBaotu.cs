using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TGiayBaotu
    {
        public int IdBaotu { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public long IdQuyen { get; set; }
        public string MauBaotu { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string Serie { get; set; }
        public DateTime? NgayBaotu { get; set; }
        public string MagiayBaotu { get; set; }
        public bool? Tuvongtrnduong { get; set; }
        public DateTime? NgayNhapngu { get; set; }
        public DateTime? NgayBibenh { get; set; }
        public DateTime? NgayVaovien { get; set; }
        public DateTime? NgayTuvong { get; set; }
        public string Noichuyenden { get; set; }
        public string Noidieutritruoc { get; set; }
        public string ChandoanVaovien { get; set; }
        public string ChandoanCuoicung { get; set; }
        public string Bienchung { get; set; }
        public string Phuongphapdieutri { get; set; }
        public string Ykienhoichanlucnguykich { get; set; }
        public string Nguyennhantuvong { get; set; }
        public string Loidichuc { get; set; }
        public string Ykiencuagiamdoc { get; set; }
        public string Noimaitang { get; set; }
        public DateTime? Ngaymaitang { get; set; }
        public string HotenNguoithan { get; set; }
        public string DienthoaiNguoithan { get; set; }
        public int? NguoilapBaotu { get; set; }
        public int? ThutruongDonvi { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? Ngayhuy { get; set; }
        public int? IdNguoihuy { get; set; }
        public string Lydohuy { get; set; }
        public int? Dagui { get; set; }
        public DateTime? Ngaygui { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
