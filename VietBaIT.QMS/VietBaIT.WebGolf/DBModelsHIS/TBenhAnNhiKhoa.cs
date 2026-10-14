using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhAnNhiKhoa
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBaNoitru { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string NgaySinh { get; set; }
        public short? NgoaiKieu { get; set; }
        public string ThangSinh { get; set; }
        public string NgheNghiep { get; set; }
        public string DanToc { get; set; }
        public string NoiLamViec { get; set; }
        public string ThongtinLhe { get; set; }
        public string DthoaiLhe { get; set; }
        public string HotenBo { get; set; }
        public string TrinhDoBo { get; set; }
        public string NgheNghiepBo { get; set; }
        public string HoTenMe { get; set; }
        public string TrinhDoMe { get; set; }
        public string NgheNghiepMe { get; set; }
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
        public string CdRvientruocPt { get; set; }
        public string CdMaRvientruocPt { get; set; }
        public string CdRviensauPt { get; set; }
        public string CdMaRviensauPt { get; set; }
        public short? TtrvKquaDtri { get; set; }
        public short? TtrvGphauBenh { get; set; }
        public string TtrvTvong { get; set; }
        public short? TtrvLdoTgianTvong { get; set; }
        public short? TtrvLdoTvong { get; set; }
        public string TtrvNnhanTvong { get; set; }
        public short? TtrvKhamNghiem { get; set; }
        public string TtrvCdoanGphau { get; set; }
        public string BaLdvv { get; set; }
        public string BaNgayThu { get; set; }
        public string BaQtbl { get; set; }
        public string BaTsbBanThan { get; set; }
        public string BaTsbGiaDinh { get; set; }
        public short? QtstConThu { get; set; }
        public short? QtstTienThai { get; set; }
        public short? QtstTtkhiSinh { get; set; }
        public string QtstCanNang { get; set; }
        public short? QtstDiTat { get; set; }
        public string QtstCuTheDiTat { get; set; }
        public string QtstPhatTrienTt { get; set; }
        public string QtstPhatTrienVd { get; set; }
        public string QtstBenhLyKhac { get; set; }
        public short? QtstNuoiDuong { get; set; }
        public short? QtStCaiSuaThang { get; set; }
        public short? QtstChamSoc { get; set; }
        public short? QtstTclao { get; set; }
        public short? QtstTcbaiLiet { get; set; }
        public short? QtstTcsoi { get; set; }
        public short? QtstTchoGa { get; set; }
        public short? QtstTcuonVan { get; set; }
        public short? QtstTcbachCau { get; set; }
        public short? QtstTckhac { get; set; }
        public string QtstBenhKhac { get; set; }
        public string KbToanThan { get; set; }
        public string KbChieuCao { get; set; }
        public string KbVongNguc { get; set; }
        public string KbVongDau { get; set; }
        public string KbMach { get; set; }
        public string KbNhietDo { get; set; }
        public string KbHuyetAp { get; set; }
        public string KbNhipTho { get; set; }
        public string KbCanNang { get; set; }
        public string KbTuanHoan { get; set; }
        public string KbHoHap { get; set; }
        public string KbTieuHoa { get; set; }
        public string KbThanKinh { get; set; }
        public string KbCoXuongKhop { get; set; }
        public string KbThanTietnieu { get; set; }
        public string KbKhac { get; set; }
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
        public string NguoiIn { get; set; }
        public DateTime? NgayIn { get; set; }
        public string MaCoso { get; set; }
    }
}
