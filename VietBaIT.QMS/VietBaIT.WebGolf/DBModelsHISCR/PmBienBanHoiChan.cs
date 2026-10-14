using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmBienBanHoiChan
    {
        public int IdBienBanHoiChan { get; set; }
        public int IdSoBienBanHoiChan { get; set; }
        public string YeuCauHoiChan { get; set; }
        public string DienBienTienSuBenh { get; set; }
        public string DienBienTinhTrang { get; set; }
        public string DienBienChanDoan { get; set; }
        public string DienBienDienBienBenh { get; set; }
        public string DienBienQuaTrinhDieutri { get; set; }
        public string DienBienQuaTrinhChamSoc { get; set; }
        public string YkienChanDoan { get; set; }
        public string YkienNguyenNhan { get; set; }
        public string YkienTienLuong { get; set; }
        public string YkienPhuongPhapDieuTri { get; set; }
        public string YkienChamSoc { get; set; }
        public string KetLuanChanDoan { get; set; }
        public string KetLuanHuongXuTri { get; set; }
        public string KetLuanTienLuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
    }
}
