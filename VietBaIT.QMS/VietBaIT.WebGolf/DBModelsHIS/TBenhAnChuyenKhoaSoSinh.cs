using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhAnChuyenKhoaSoSinh
    {
        public long Id { get; set; }
        public string SoVaoVien { get; set; }
        public string MaBaNoitru { get; set; }
        public string HcHoTenMe { get; set; }
        public DateTime? HcNgaySinhMe { get; set; }
        public int? HcLanDe { get; set; }
        public string HcNgheNghiepMe { get; set; }
        public string HcHotenBo { get; set; }
        public DateTime? HcNgaySinhBo { get; set; }
        public string HcNgheNghiepBo { get; set; }
        public string HcNhomMauMe { get; set; }
        public string HcTienThai { get; set; }
        public string HcNguoiBaoTin { get; set; }
        public string HcDienThoaiNguoiBaoTin { get; set; }
        public bool? HcNgoaiKieu { get; set; }
        public string HcDanToc { get; set; }
        public string HcThongtinLhe { get; set; }
        public string HcDthoaiLhe { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string GioPhutVaoVien { get; set; }
        public int? QlnbTtiepVao { get; set; }
        public string QlnbKhoa { get; set; }
        public int? QlnbNgioiThieu { get; set; }
        public string QlnbLanVvien { get; set; }
        public int? QlnbChuyenVien { get; set; }
        public string QlnbChuyenDen { get; set; }
        public string QlnbRaVien { get; set; }
        public int? QlnbLdoRvien { get; set; }
        public double? QlnbTongNgayDt { get; set; }
        public string CdNoiChuyenDen { get; set; }
        public string CdMaNoiChuyenDen { get; set; }
        public string CdKkbCcuu { get; set; }
        public string CdMaKkbCcuu { get; set; }
        public string CdKhoaDtri { get; set; }
        public string CdMaKhoaDtri { get; set; }
        public bool? CdThuThuat { get; set; }
        public bool? CdPhauThuat { get; set; }
        public string CdRvienBchinh { get; set; }
        public string CdMaRvienBchinh { get; set; }
        public string CdRvienBphu { get; set; }
        public string CdMaRvienBphu { get; set; }
        public bool? CdTaiBien { get; set; }
        public bool? CdBienChung { get; set; }
        public int? TtrvKquaDtri { get; set; }
        public int? TtrvGphauBenh { get; set; }
        public string TtrvTvong { get; set; }
        public int? TtrvLdoTgianTvong { get; set; }
        public int? TtrvLdoTvong { get; set; }
        public string TtrvNnhanTvong { get; set; }
        public bool? TtrvKhamNghiem { get; set; }
        public string TtrvCdoanGphau { get; set; }
        public string AiHoiBenh { get; set; }
        public string AiiaGioOiVo { get; set; }
        public string AiiaPhutOiVo { get; set; }
        public DateTime? AiiaNgayOiVo { get; set; }
        public string AiiaMauSac { get; set; }
        public string AiiaCachDe { get; set; }
        public string AiiaGioDe { get; set; }
        public string AiiaPhutDe { get; set; }
        public DateTime? AiiaNgayDe { get; set; }
        public string AiiaLyDoCanThiep { get; set; }
        public string AiibTinhTrangSoSinhKhiRaDoi { get; set; }
        public string AiibHoTenChucDanhNguoiDoDe { get; set; }
        public string AiibApgar1Phut { get; set; }
        public string AiibApgar5phut { get; set; }
        public string AiibApgar10phut { get; set; }
        public string AiibCanNang { get; set; }
        public string AiibTinhTrangDinhDuongSauSinh { get; set; }
        public string AiicPhuongPhapHoiSinhNgaySauDe { get; set; }
        public string AiiiHoTenChucDanhNguoiChuyenSoSinh { get; set; }
        public bool? Aiii1DiTatBamSinh { get; set; }
        public bool? Aiii1CoHauMon { get; set; }
        public string Aiii1CuTheDiTatBamSinh { get; set; }
        public string Aiii1TinhHinhSoSinhKhiVaoKhoa { get; set; }
        public string Aiii1TinhTrangToanThan { get; set; }
        public bool? Aiii1MauDaHongHao { get; set; }
        public bool? Aiii1MauDaXanhTai { get; set; }
        public bool? Aiii1MauDaVang { get; set; }
        public bool? Aiii1MauDaTim { get; set; }
        public bool? Aiii1MauDaKhac { get; set; }
        public string Aiii1MauDaKhacText { get; set; }
        public string Aiii2HoHapNhipTho { get; set; }
        public string Aiii2HoHapNghePhoi { get; set; }
        public string Aiii2HoHapChiSoSilVerMan { get; set; }
        public string Aiii2TimMach { get; set; }
        public string Aiii2Bung { get; set; }
        public string Aiii2CoQuanSinhDucNgoai { get; set; }
        public string Aiii2XuongKhop { get; set; }
        public string Aiii2ThanKinhPhanXa { get; set; }
        public string Aiii2ThanKinhTruongLucCo { get; set; }
        public string Aiii3CacXetNghiemCls { get; set; }
        public string Aiii4TomTatBenhAn { get; set; }
        public string Aiii5ChiDinhTheoDoi { get; set; }
        public DateTime? ANgayLamBenhAn { get; set; }
        public string ABacSyLamBenhAn { get; set; }
        public string BDienBien { get; set; }
        public string BTomTatKetQuaXn { get; set; }
        public string BPpdieuTri { get; set; }
        public string BTinhTrangRaVien { get; set; }
        public string BHuongDieuTri { get; set; }
        public string BNguoiGiaoHoSo { get; set; }
        public string BNguoiNhanHoSo { get; set; }
        public DateTime? BNgayTongKet { get; set; }
        public string BBacSyDieuTri { get; set; }
        public int? BXquang { get; set; }
        public int? BCtscanner { get; set; }
        public int? BSieuAm { get; set; }
        public int? BXetNghiem { get; set; }
        public int? BKhac { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
