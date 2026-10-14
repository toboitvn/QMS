using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhAnTruyenNhiem
    {
        public long Id { get; set; }
        public string SoVaoVien { get; set; }
        public string MaBaNoitru { get; set; }
        public string HcNgheNghiep { get; set; }
        public string HcKhoa { get; set; }
        public string HcGiuong { get; set; }
        public bool? HcNgoaiKieu { get; set; }
        public string HcDanToc { get; set; }
        public string HcNoiLamViec { get; set; }
        public int? HcDoiTuong { get; set; }
        public string HcSoTheBhyt { get; set; }
        public DateTime? HcNgayHetHanBhyt { get; set; }
        public string HcNguoiBaoTin { get; set; }
        public string HcDtnguoiBaoTin { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public string GioVaoVien { get; set; }
        public string PhutVaoVien { get; set; }
        public int? QlnbTtiepVao { get; set; }
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
        public string A1LyDoVaoVien { get; set; }
        public int? A1NgayBenh { get; set; }
        public string A21QuaTrinhBenhLy { get; set; }
        public string A22BanThan { get; set; }
        public string A22DacDiemLienQuanBenh { get; set; }
        public string A22GiaDinh { get; set; }
        public string A23DichTe { get; set; }
        public string A23BenhCapTinh { get; set; }
        public string A23NoiSongTruocHoacTrongKhiBenh { get; set; }
        public string A23ThoiGian { get; set; }
        public string A23MoiSinh { get; set; }
        public string A31ToanThan { get; set; }
        public string A32TuanHoan { get; set; }
        public string A32HoHap { get; set; }
        public string A32TieuHoa { get; set; }
        public string A32ThanTietNieu { get; set; }
        public string A32ThanKinh { get; set; }
        public string A32CoXuongKhop { get; set; }
        public string A32TmhRhmMat { get; set; }
        public string A33CacXetNghiemCls { get; set; }
        public string A34TomTatBenhAn { get; set; }
        public string A35ChiDinhTheoDoi { get; set; }
        public string A4BenhChinh { get; set; }
        public string A4BenhKem { get; set; }
        public string A4PhanBiet { get; set; }
        public string A5TienLuong { get; set; }
        public string A6HuongDieuTri { get; set; }
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
