using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuKhamThai
    {
        public int IdPhieuKhamthai { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int DepartmentId { get; set; }
        public DateTime NgayKham { get; set; }
        public string NguoiKham { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Artery { get; set; }
        public string BodyTemp { get; set; }
        public string BloodPres { get; set; }
        public string BreatheRate { get; set; }
        public string LanKhamTruocChanDoan { get; set; }
        public string LanKhamTruocXuTri { get; set; }
        public DateTime? LanKhamTruocNgayKham { get; set; }
        public string HoiBenhLyDoVaoVien { get; set; }
        public int? HoiBenhLanCoThaiThu { get; set; }
        public int? HoiBenhSoLanKhamThai { get; set; }
        public DateTime? HoiBenhNgayDauKyKinhCuoi { get; set; }
        public int? HoiBenhTuoiThai { get; set; }
        public DateTime? HoiBenhNgayDuKienSinh { get; set; }
        public string HoiBenhDienBienLamSang { get; set; }
        public string HoiBenhToanThan { get; set; }
        public string HoiBenhToanThanMota { get; set; }
        public int? HoiBenhSoLanTiemUonVan { get; set; }
        public string TienSuBenhDiUng { get; set; }
        public string TienSuBenhDiUngMota { get; set; }
        public string TienSuBenhTienSuBenh { get; set; }
        public string TienSuBenhBenhHuyetAp { get; set; }
        public string TienSuBenhBenhTim { get; set; }
        public string TienSuBenhBenhHoHap { get; set; }
        public string TienSuBenhBenhTuyenGiap { get; set; }
        public string TienSuBenhBenhThan { get; set; }
        public string TienSuBenhDaiThaoDuong { get; set; }
        public string TienSuBenhKhac { get; set; }
        public string TienSuBenhThuocDangDung { get; set; }
        public string TienSuBenhThuocDangDungMoTa { get; set; }
        public string TienSuBenhTienSuPhauThuat { get; set; }
        public string TienSuBenhTienSuPhauThuatMoTa { get; set; }
        public string TienSuBenhPara { get; set; }
        public string TienSuBenhChuKyKinh { get; set; }
        public int? TienSuBenhSoNgayChuKy { get; set; }
        public string TienSuBenhPhauThuatPhuKhoa { get; set; }
        public string TienSuBenhPhauThuatPhuKhoaMoTa { get; set; }
        public string TienSuBenhKhoiUbuongTrung { get; set; }
        public string TienSuBenhKhoiUtuCung { get; set; }
        public string TienSuBenhDiDangSinhDuc { get; set; }
        public string TienSuBenhTangSinhMon { get; set; }
        public string TienSuBenhSaTangChau { get; set; }
        public string TienSuBenhBenhPhuKhoaDaMacVaDieuTri { get; set; }
        public string TienSuGiaDinh { get; set; }
        public string TienSuGiaDinhDaThai { get; set; }
        public string TienSuGiaDinhDiDang { get; set; }
        public string TienSuGiaDinhBenhDiTruyen { get; set; }
        public string TienSuGiaDinhDaiThaoDuong { get; set; }
        public string TienSuGiaDinhTangHuyetAp { get; set; }
        public string TienSuGiaDinhKhac { get; set; }
        public string KhamBenhTinhThan { get; set; }
        public string KhamBenhPhu { get; set; }
        public string KhamBenhProteinNieu { get; set; }
        public int? KhamBenhProteinNieuHamLuong { get; set; }
        public string KhamBenhSeoMoCu { get; set; }
        public string KhamBenhKhungChau { get; set; }
        public int? KhamBenhChieuCaoTuCung { get; set; }
        public int? KhamBenhVongBung { get; set; }
        public string KhamBenhNgoiThai { get; set; }
        public string KhamBenhNgoiThaiMoTa { get; set; }
        public string KhamBenhConCoTuCung { get; set; }
        public string KhamBenhConCoTuCungTanSo { get; set; }
        public string KhamBenhTimThai { get; set; }
        public int? KhamBenhTimThaiNhipTimThai { get; set; }
        public string KhamBenhCoTuCung { get; set; }
        public int? KhamBenhCoTuCungMoRong { get; set; }
        public string KhamBenhDauOi { get; set; }
        public int? KhamBenhDauOiGio { get; set; }
        public int? KhamBenhDauOiPhut { get; set; }
        public string KhamBenhNuocOi { get; set; }
        public bool? ClsXetNghiemMauNgoaiVi { get; set; }
        public bool? ClsXetNghiemDongMau { get; set; }
        public bool? ClsXetNghiemSinhHoaMau { get; set; }
        public bool? ClsXetNghiemHiv { get; set; }
        public bool? ClsXetNghiemViemGanB { get; set; }
        public bool? ClsXetNghiemGiangMai { get; set; }
        public bool? ClsXetNghiemProteinNuocTieu { get; set; }
        public bool? ClsSieuAm { get; set; }
        public string ClsKetQuaThieuMau { get; set; }
        public string ClsKetQuaDongMau { get; set; }
        public string ClsKetQuaDuongMau { get; set; }
        public string ClsKetQuaHiv { get; set; }
        public string ClsKetQuaViemGanB { get; set; }
        public string ClsKetQuaGiangMai { get; set; }
        public string ClsKetQuaProteinNieu { get; set; }
        public string ClsKetQuaSieuAm { get; set; }
        public string ClsXetNghiemKhac { get; set; }
        public string ChanDoanMaBenh { get; set; }
        public string ChanDoanTenBenh { get; set; }
        public string KeHoachDieuTri { get; set; }
        public string KeHoachDieuTriHuongDieuTri { get; set; }
        public string KeHoachDieuTriTuVanGiaoDuc { get; set; }
        public string KeHoachDieuTriTuVanGiaoDucMoTa { get; set; }
        public string TienLuong { get; set; }
        public string LanKhamKeTiepHenTaiKham { get; set; }
        public string LanKhamKeTiepLuuY { get; set; }
        public string LanKhamKeTiepNguoiKham { get; set; }
    }
}
