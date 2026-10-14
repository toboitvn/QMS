using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmPhieuChuanBiVaBanGiaoTruocMo
    {
        public long IdPhieu { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdPhongMo { get; set; }
        public bool? GiaiThichChuanBiTamLy { get; set; }
        public bool? ThongBaoThoiGianDuKienMo { get; set; }
        public bool? BndaNhinAn { get; set; }
        public bool? TamGoiTayTrang { get; set; }
        public bool? Vsrang { get; set; }
        public bool? CatMongTayMongChan { get; set; }
        public bool? VssachVungMo { get; set; }
        public bool? BangVoTrung { get; set; }
        public bool? BnduocThutThao { get; set; }
        public bool? ThaoBoHetDoTrangSuc { get; set; }
        public bool? ThaoRangGia { get; set; }
        public bool? MacQuanAoSach { get; set; }
        public bool? CoDinhTamThoiChiGay { get; set; }
        public bool? DungThuocAnThanTruocMo { get; set; }
        public bool? HsbaduDaThongQuaMo { get; set; }
        public bool? KhamVoCamTruocMo { get; set; }
        public bool? DiUngThuoc { get; set; }
        public bool? BanGiao { get; set; }
        public string Ykien { get; set; }
        public string NguoiGiaoBn { get; set; }
        public string NguoiNhanBn { get; set; }
        public string GiaiThichChuanBiTamLyGhiChu { get; set; }
        public string ThongBaoThoiGianDuKienMoGhiChu { get; set; }
        public string BndaNhinAnGhiChu { get; set; }
        public string TamGoiTayTrangGhiChu { get; set; }
        public string VsrangGhiChu { get; set; }
        public string CatMongTayMongChanGhiChu { get; set; }
        public string VssachVungMoGhiChu { get; set; }
        public string BangVoTrungGhiChu { get; set; }
        public string BnduocThutThaoGhiChu { get; set; }
        public string ThaoBoHetDoTrangSucGhiChu { get; set; }
        public string ThaoRangGiaGhiChu { get; set; }
        public string MacQuanAoSachGhiChu { get; set; }
        public string CoDinhTamThoiChiGayGhiChu { get; set; }
        public string DungThuocAnThanTruocMoGhiChu { get; set; }
        public string HsbaduDaThongQuaMoGhiChu { get; set; }
        public string KhamVoCamTruocMoGhiChu { get; set; }
        public string DiUngThuocGhiChu { get; set; }
        public string BanGiaoGhiChu { get; set; }
        public DateTime? ThoiGianDuaDiMo { get; set; }
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
