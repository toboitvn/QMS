using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuBangiaoTinhtrangNguoibenh
    {
        public int IdBangiao { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? NhanlucBacsi { get; set; }
        public int? NhanlucDieuduong { get; set; }
        public int? NhanlucHoly { get; set; }
        public int? NhanlucKythuatvien { get; set; }
        public string NhanlucKhac { get; set; }
        public bool? PhuongtienXeday { get; set; }
        public int? PhuongtienSlxeday { get; set; }
        public bool? PhuongtienCang { get; set; }
        public int? PhuongtienSlcang { get; set; }
        public bool? PhuongtienGiuong { get; set; }
        public int? PhuongtienSlgiuong { get; set; }
        public bool? PhuongtienDuongtruyentinhmach { get; set; }
        public int? PhuongtienSlduongtruyentinhmach { get; set; }
        public bool? PhuongtienHosobenhan { get; set; }
        public int? PhuongtienSlhosobenhan { get; set; }
        public bool? PhuongtienFilm { get; set; }
        public int? PhuongtienSlfilm { get; set; }
        public bool? PhuongtienCtscaner { get; set; }
        public int? PhuongtienSlctscaner { get; set; }
        public string PhuongtienThietbikhac { get; set; }
        public bool? TtlucdiTinh { get; set; }
        public bool? TtlucdiLomo { get; set; }
        public bool? TtlucdiHonme { get; set; }
        public DateTime? TtlucdiThoigiangiao { get; set; }
        public string TtlucdiMach { get; set; }
        public string TtlucdiHuyetap { get; set; }
        public string TtlucdiNhietdo { get; set; }
        public string TtlucdiSpo2 { get; set; }
        public string TtlucdiNhiptho { get; set; }
        public bool? TtlucdenTinh { get; set; }
        public bool? TtlucdenLomo { get; set; }
        public bool? TtlucdenHonme { get; set; }
        public DateTime? TtlucdenThoigiannhan { get; set; }
        public string TtlucdenMach { get; set; }
        public string TtlucdenHuyetap { get; set; }
        public string TtlucdenNhietdo { get; set; }
        public string TtlucdenSpo2 { get; set; }
        public string TtlucdenNhiptho { get; set; }
        public string Vandekhac { get; set; }
        public int KhoaBangiao { get; set; }
        public int KhoaNhanbangiao { get; set; }
        public int NguoiBangiao { get; set; }
        public int? NguoiNhanbangiao { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
