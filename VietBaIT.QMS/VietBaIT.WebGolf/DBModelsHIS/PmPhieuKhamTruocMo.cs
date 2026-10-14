using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmPhieuKhamTruocMo
    {
        public int IdPhieu { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdPhongMo { get; set; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string NhomMau { get; set; }
        public string NhinAn { get; set; }
        public string ChanDoanTruocMo { get; set; }
        public string DuKienPpmo { get; set; }
        public string DiUng { get; set; }
        public string Nghien { get; set; }
        public string NoiKhoa { get; set; }
        public string NgoaiKhoa { get; set; }
        public string TinhTrangChung { get; set; }
        public int? Mach { get; set; }
        public string HuyetAp { get; set; }
        public string Ecg { get; set; }
        public string Echo { get; set; }
        public int? NhipTho { get; set; }
        public string Rrpn { get; set; }
        public int? Mallampati { get; set; }
        public string HaMieng { get; set; }
        public string CamGiap { get; set; }
        public string RangGia { get; set; }
        public string CotSong { get; set; }
        public string LuuY { get; set; }
        public int? Asa { get; set; }
        public string PpvoCam { get; set; }
        public string PpgiamDau { get; set; }
        public string DuKienKhoKhan { get; set; }
        public string ThuocChuanBi { get; set; }
        public string DeNghi { get; set; }
        public string BsgayMe { get; set; }
        public bool? DongYphauThuat { get; set; }
        public DateTime? NgayKhamTruocMo { get; set; }
        public string BslamPhieu { get; set; }
        public string TienLuong { get; set; }
        public DateTime? DuKienNgayMo { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string MaPpvoCamChuan { get; set; }
        public string DuKienTienMe { get; set; }
        public bool? DaKham { get; set; }
        public int? TrangThaiPhieu { get; set; }
        public DateTime? NgayChuyenMo { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
        public int? LoaiPt { get; set; }
        public string NhomMauRh { get; set; }
        public string LyDoKhongDongY { get; set; }
    }
}
