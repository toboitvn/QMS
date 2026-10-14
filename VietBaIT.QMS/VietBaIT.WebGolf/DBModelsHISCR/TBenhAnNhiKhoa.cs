using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBenhAnNhiKhoa
    {
        public int Id { get; set; }
        public int MaBenhAn { get; set; }
        public int MaBn { get; set; }
        public int MaLanKham { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public short? Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        public string DiaChi { get; set; }
        public string DiaChiNguoiNha { get; set; }
        public string HoTenBo { get; set; }
        public string TrinhDoBo { get; set; }
        public string NgheNghiepBo { get; set; }
        public string HoTenMe { get; set; }
        public string TrinhDoMe { get; set; }
        public string NgheNghiepMe { get; set; }
        public byte? KieuDoiTuong { get; set; }
        public string SoTheBhyt { get; set; }
        public string NgayHetHanBhyt { get; set; }
        public string VaoVienLuc { get; set; }
        public byte? TrucTiepVao { get; set; }
        public byte? NoiGioiThieu { get; set; }
        public byte? VvDoBenhNayLanThu { get; set; }
        public string VaoKhoa { get; set; }
        public string VaoKhoaLuc { get; set; }
        public short? SoNgayDieuTri { get; set; }
        public string ChuyenKhoa1 { get; set; }
        public string ChuyenKhoa1Luc { get; set; }
        public short? SoNgayDieuTri1 { get; set; }
        public string ChuyenKhoa2 { get; set; }
        public string ChuyenKhoa2Luc { get; set; }
        public short? SoNgayDieuTri2 { get; set; }
        public string ChuyenKhoa3 { get; set; }
        public string ChuyenKhoa3Luc { get; set; }
        public short? SoNgayDieuTri3 { get; set; }
        public byte? ChuyenVien { get; set; }
        public string ChuyenVienChiTiet { get; set; }
        public string RaVienLuc { get; set; }
        public byte? RaVienKieu { get; set; }
        public short? TongNgayDieuTri { get; set; }
        public string CdNoiChuyenDen { get; set; }
        public string CdNoiChuyenDenMa { get; set; }
        public string CdKkb { get; set; }
        public string CdKkbMa { get; set; }
        public string KhiVaoKhoaDieuTri { get; set; }
        public string KhiVaoKhoaDieuTriMa { get; set; }
        public bool? KhiVaoKhoaDieuTriKieu { get; set; }
        public string RvBenhChinh { get; set; }
        public string RvBenhChinhMa { get; set; }
        public string RvBenhPhu { get; set; }
        public string RvBenhPhuMa { get; set; }
        public bool? RvKieu { get; set; }
        public byte? TtrvKq { get; set; }
        public byte? TtrvGiaiPhauBenh { get; set; }
        public string TtrvNnTuVong { get; set; }
        public string TtrvNnTuVongMa { get; set; }
        public string TtrvDeadTime { get; set; }
        public byte? TtrvDeadType { get; set; }
        public bool? TtrvDeadBefore24h { get; set; }
        public bool? TtrvKhamNghiemTuThi { get; set; }
        public string TtrvKhamNghiemTuThiChiTiet { get; set; }
        public string TtrvKhamNghiemTuThiMa { get; set; }
        public string Ldvv { get; set; }
        public short? VaoNgayThuXcuaBenh { get; set; }
        public string HbQtbl { get; set; }
        public string HbTsbBanThan { get; set; }
        public string HbTsbGiaDinh { get; set; }
        public byte? HbQtstConThuX { get; set; }
        public byte? HbQtstCanNangLucSinh { get; set; }
        public byte? HbQtstTienThaiPara { get; set; }
        public byte? HbQtstTtKhiSinh { get; set; }
        public bool? HbQtstDiTatBamSinh { get; set; }
        public string HbQtstDiTatBamSinhDetail { get; set; }
        public string HbQtstPtVeTinhThan { get; set; }
        public string HbQtstPtVeVanDong { get; set; }
        public string HbQtstBenhLyKhac { get; set; }
        public string HbQtstDaTiemChung { get; set; }
        public string HbQtstDaTiemChungKhac { get; set; }
        public string HbQtstNuoiDuong { get; set; }
        public byte? HbQtstCaiSuaThangThuX { get; set; }
        public string HbQtstChamSoc { get; set; }
        public short? KbChieuCao { get; set; }
        public short? KbVongNguc { get; set; }
        public short? KbVongDau { get; set; }
        public short? KbMach { get; set; }
        public short? KbNhietDo { get; set; }
        public short? KbHuyetApTu { get; set; }
        public short? KbHuyetApDen { get; set; }
        public short? KbNhipTho { get; set; }
        public byte? KbCanNang { get; set; }
        public string KbTuanHoan { get; set; }
        public string KbHoHap { get; set; }
        public string KbTieuHoa { get; set; }
        public string KbThanTietNieu { get; set; }
        public string KbThanKinh { get; set; }
        public string KbCoXuongKhop { get; set; }
        public string KbTaiMuiHong { get; set; }
        public string KbXnclsCanLam { get; set; }
        public string KbTtBenhAn { get; set; }
        public string CdkvkddBenhChinh { get; set; }
        public string CdkvkddBenhPhu { get; set; }
        public string CdkvkddPhanBiet { get; set; }
        public string TienLuong { get; set; }
        public string HuongDieuTri { get; set; }
        public string TkbaQtbl { get; set; }
        public string TkbaTtkq { get; set; }
        public string TkbaPpdt { get; set; }
        public string TkbaTtrv { get; set; }
        public string TkbaHuongDieuTriTiep { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string Sdt { get; set; }
        public string VaoVienNgay { get; set; }
    }
}
