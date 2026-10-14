using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBenhanNoitru
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBaNoitru { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public string NgaySinh { get; set; }
        public short? NgoaiKieu { get; set; }
        public string ThangSinh { get; set; }
        public string NgheNghiep { get; set; }
        public string DanToc { get; set; }
        public string NoiLamViec { get; set; }
        public string ThongtinLhe { get; set; }
        public string DthoaiLhe { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string GioPhutVaoVien { get; set; }
        public short? QlnbTtiepVao { get; set; }
        public string QlnbKhoa { get; set; }
        public short? QlnbNgioiThieu { get; set; }
        public string QlnbLanVvien { get; set; }
        public short? QlnbChuyenVien { get; set; }
        public string QlnbChuyenDen { get; set; }
        public string QlnbRaVien { get; set; }
        public short? QlnbLdoRvien { get; set; }
        public short? QlnbTongNgayDt { get; set; }
        public string CdNoiChuyenDen { get; set; }
        public string CdMaNoiChuyenDen { get; set; }
        public string CdKkbCcuu { get; set; }
        public string CdMaKkbCcuu { get; set; }
        public string CdKhoaDtri { get; set; }
        public string CdMaKhoaDtri { get; set; }
        public short? CdThuThuat { get; set; }
        public short? CdPhauThuat { get; set; }
        public string CdRvienBchinh { get; set; }
        public string CdMaRvienBchinh { get; set; }
        public string CdRvienBphu { get; set; }
        public string CdMaRvienBphu { get; set; }
        public short? CdTaiBien { get; set; }
        public short? CdBienChung { get; set; }
        public short? TtrvKquaDtri { get; set; }
        public short? TtrvGphauBenh { get; set; }
        public string TtrvTvong { get; set; }
        public short? TtrvLdoTvong { get; set; }
        public string TtrvNnhanTvong { get; set; }
        public short? TtrvKhamNghiem { get; set; }
        public string TtrvCdoanGphau { get; set; }
        public string BaLdvv { get; set; }
        public string BaNgayThu { get; set; }
        public string BaQtbl { get; set; }
        public string BaTsb { get; set; }
        public short? BaDiUng { get; set; }
        public short? BaMaTuy { get; set; }
        public short? BaRuouBia { get; set; }
        public short? BaThuocLa { get; set; }
        public short? BaThuocLao { get; set; }
        public short? BaKhac { get; set; }
        public string BaTgDiUng { get; set; }
        public string BaTgMaTuy { get; set; }
        public string BaTgRuouBia { get; set; }
        public string BaTgThuocLa { get; set; }
        public string BaTgThuocLao { get; set; }
        public string BaTgKhac { get; set; }
        public string BaGiaDinh { get; set; }
        public string KbToanThan { get; set; }
        public string KbMach { get; set; }
        public string KbNhietDo { get; set; }
        public string KbHuyetAp { get; set; }
        public string KbNhipTho { get; set; }
        public string KbCanNang { get; set; }
        public string KbTuanHoan { get; set; }
        public string KbHoHap { get; set; }
        public string KbTieuHoa { get; set; }
        public string KbThan { get; set; }
        public string KbThanKinh { get; set; }
        public string KbCo { get; set; }
        public string KbTai { get; set; }
        public string KbRang { get; set; }
        public string KbMat { get; set; }
        public string KbNoiTiet { get; set; }
        public string KbXnCls { get; set; }
        public string KbTtba { get; set; }
        public string KbBenhChinh { get; set; }
        public string KbBenhPhu { get; set; }
        public string KbPhanBiet { get; set; }
        public string KbTienLuong { get; set; }
        public string KbHuongDtri { get; set; }
        public string TkbaQtbl { get; set; }
        public string TkbaTtkqxn { get; set; }
        public string TkbaPpdt { get; set; }
        public string TkbaTtrv { get; set; }
        public string TkbaHdt { get; set; }
        public string Khoa { get; set; }
        public string Phong { get; set; }
        public string Giuong { get; set; }
        public string NguoiIn { get; set; }
        public string BenhNgoaiKhoa { get; set; }
        public DateTime? NgayIn { get; set; }
        public string MaCoso { get; set; }
        public short? Cddophauthuat { get; set; }
        public short? Cddogayme { get; set; }
        public short? Cddonhiemkhuan { get; set; }
        public short? Cdkhac { get; set; }
        public string Cdsongaydtsaupt { get; set; }
        public string Cdsolanpt { get; set; }
        public string CdRvientruocPt { get; set; }
        public string CdMaRvientruocPt { get; set; }
        public string CdRviensauPt { get; set; }
        public string CdMaRviensauPt { get; set; }
        public string NguoiGiaoHoSo { get; set; }
        public string NguoiNhanHoSo { get; set; }
        public string BsdieuTri { get; set; }
        public DateTime? NgayTongKetBa { get; set; }
        public int? StXquang { get; set; }
        public int? StCtscanner { get; set; }
        public int? StSieuAm { get; set; }
        public int? StXetNghiem { get; set; }
        public int? StKhac { get; set; }
        public string KbChieuCao { get; set; }
        public string KbBmi { get; set; }
    }
}
