using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBenhanHivAids
    {
        public int IdBenhan { get; set; }
        public string SoBenhan { get; set; }
        public DateTime? NgaylapBenhan { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdThe { get; set; }
        public DateTime? NgaykdHiv { get; set; }
        public DateTime? BddtArv { get; set; }
        public string MaPhacDoDieuTriBd { get; set; }
        public decimal? MaBacPhacDoBd { get; set; }
        public decimal? MaLydoDtri { get; set; }
        public decimal? LoaiDtriLao { get; set; }
        public decimal? PhacdoDtriLao { get; set; }
        public DateTime? NgaybdDtriLao { get; set; }
        public DateTime? NgayktDtriLao { get; set; }
        public decimal? MaLydoXntlVr { get; set; }
        public DateTime? NgayXnTlvr { get; set; }
        public decimal? KqXntlVr { get; set; }
        public DateTime? NgayKqXnTlvr { get; set; }
        public decimal? MaLoaiBn { get; set; }
        public string MaTinhTrangDk { get; set; }
        public decimal? LanXnPcr { get; set; }
        public DateTime? NgayXnPcr { get; set; }
        public DateTime? NgayKqXnPcr { get; set; }
        public decimal? MaKqXnPcr { get; set; }
        public DateTime? NgayNhanTtMangThai { get; set; }
        public DateTime? NgayBatDauDtCtx { get; set; }
        public decimal? MaXuTri { get; set; }
        public DateTime? NgayBatDauXuTri { get; set; }
        public DateTime? NgayKetThucXuTri { get; set; }
        public string MaPhacDoDieuTri { get; set; }
        public decimal? MaBacPhacDo { get; set; }
        public decimal? SoNgayCapThuocArv { get; set; }
        public string DuPhong { get; set; }
        public int? DaGui { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string IpMaySua { get; set; }
    }
}
