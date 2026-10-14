using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBenhanTha
    {
        public long IdBenhan { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string SoBenhan { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public short? NgoaiKieu { get; set; }
        public string NgheNghiep { get; set; }
        public string DanToc { get; set; }
        public string NoiLamViec { get; set; }
        public string ThongTinLhe { get; set; }
        public string DthoaiLhe { get; set; }
        public DateTime? NgayTaoBa { get; set; }
        public string ThoiGianTaoBa { get; set; }
        public short? QlnbTtiepvao { get; set; }
        public string QlnbKhoa { get; set; }
        public string QlnbNgioiThieu { get; set; }
        public DateTime? QlnbLanKhamDauTien { get; set; }
        public DateTime? QlnbDieuTriNgoaiTruLuc { get; set; }
        public string QlnbChanDoan { get; set; }
        public string QlnbLyDoVaoVien { get; set; }
        public string QtblDauThatNguc { get; set; }
        public string QtblPhanDoCcs { get; set; }
        public string QtblKhoTho { get; set; }
        public string QtblPhanDoNyha { get; set; }
        public string QtblDauDau { get; set; }
        public string QtblHo { get; set; }
        public string QtblNgat { get; set; }
        public string QtblHoaMatChongMat { get; set; }
        public string QtblCacTrieuChungKhac { get; set; }
        public string QtblPhatHienThatuThang { get; set; }
        public string QtblPhatHienThatuNam { get; set; }
        public string QtblHacaoNhat { get; set; }
        public string QtblDieuTriThuongXuyen { get; set; }
        public string QtblDieuTri { get; set; }
        public string TsbtCacYeuToNguyCo { get; set; }
        public bool? TsbtHutThuoc { get; set; }
        public bool? TsbtKhongHutThuoc { get; set; }
        public string TsbtHutThuocSoDieu { get; set; }
        public string TsbtHutThuocSoBao { get; set; }
        public bool? TsbtUongRuouBia { get; set; }
        public bool? TsbtKhongUongRuouBia { get; set; }
        public string TsbtUongRuouBiaMl { get; set; }
        public string TsbtCacYeuToKhac { get; set; }
        public string TsbtCacBenhPhoiHop { get; set; }
        public string TsbtDtd { get; set; }
        public string TsbtGout { get; set; }
        public string TsbtVanTim { get; set; }
        public string TsbtDmngoaiVi { get; set; }
        public string TsbtRoiLoanLipidMau { get; set; }
        public string TsbtThan { get; set; }
        public string TsbtMachVanh { get; set; }
        public string TsbtDungThuocTranhThai { get; set; }
        public string TsbtBenhMachVanhDatStent { get; set; }
        public string TsbtBenhLyKhac { get; set; }
        public string TsbtTimMachSom { get; set; }
        public string TsbtTimMachSomNamNho55 { get; set; }
        public string TsbtTimMachSomNuNho65 { get; set; }
        public string TsbtTaiBienMachMauNao { get; set; }
        public string TsbtTaiBienMachMauNaoLan { get; set; }
        public string TsbtTaiBienMachMauNaoNhoiMauNao { get; set; }
        public string TsbtBenhMachVanh { get; set; }
        public string TsbtBenhMachVanhCanThiep { get; set; }
        public string TsbtBenhMachVanhLoaiCanThiep { get; set; }
        public string TsbtBenhMachVanhNam { get; set; }
        public string TsbtBenhMachVanhDieuTriCanThiepOdau { get; set; }
        public string TsbtBenhMachVanhDtd { get; set; }
        public string TsbtBenhMachVanhDtdPhatHienTu { get; set; }
        public string TsbtBenhMachVanhDtdDieuTriOdau { get; set; }
        public string KbHa { get; set; }
        public string KbNhipTim { get; set; }
        public string KbNhipTimDeu { get; set; }
        public string KbToanThanCan { get; set; }
        public string KbToanThanChieuCao { get; set; }
        public string KbToanThanVongBung { get; set; }
        public string KbToanThanVongHong { get; set; }
        public string KbToanThanChisoBmi { get; set; }
        public string KbToanThanNhietDo { get; set; }
        public string KbToanThanDaNiemMacHong { get; set; }
        public string KbToanThanPhu { get; set; }
        public string KbToanThanMoTa { get; set; }
        public string KbTrieuChungThucTheThMomTimLienSuon { get; set; }
        public string KbTrieuChungThucTheThMomTimDuong { get; set; }
        public string KbTrieuChungThucTheThTimTo { get; set; }
        public string KbTrieuChungThucTheThNhipTimDeu { get; set; }
        public string KbTrieuChungThucTheThNhipTimTanSo { get; set; }
        public string KbTrieuChungThucTheThNhipTimTapAm { get; set; }
        public string KbTrieuChungThucTheThNhipTimMoTa { get; set; }
        public string KbTrieuChungThucTheThTiengThoiDongMachCanh { get; set; }
        public string KbTrieuChungThucTheThTiengThoiDongMachCanhMachNgoaiVi { get; set; }
        public string KbTrieuChungThucTheThMachChiTrenBinhThuong { get; set; }
        public string KbTrieuChungThucTheThMachChiTrenMota { get; set; }
        public string KbTrieuChungThucTheThMachChiDuoiBinhThuong { get; set; }
        public string KbTrieuChungThucTheThMachChiDuoiMota { get; set; }
        public string KbTrieuChungThucTheThSuyTinhMach { get; set; }
        public string KbTrieuChungThucTheThSuyTinhMachPhanDoCeap { get; set; }
        public string KbTrieuChungThucTheThSuyTinhMachCacTrieuChung { get; set; }
        public string KbTrieuChungThucTheHhRiRaoPheNangBenTrai { get; set; }
        public string KbTrieuChungThucTheHhRiRaoPheNangBenPhai { get; set; }
        public string KbTrieuChungThucTheHhRales { get; set; }
        public string KbTrieuChungThucTheHhRalesMoTa { get; set; }
        public string KbTrieuChungThucTheThoaCoTruong { get; set; }
        public string KbTrieuChungThucTheThoaGanTo { get; set; }
        public string KbTrieuChungThucTheThoaGanToDuoiBoSuong { get; set; }
        public string KbTrieuChungThucTheThoaTinhMachCoNoi { get; set; }
        public string KbTrieuChungThucTheThoaPhanHoiGan { get; set; }
        public string KbTinhThan { get; set; }
        public string KbCacCoQuanKhac { get; set; }
        public string KqclsXetNghiemMau { get; set; }
        public string KqclsSieuAm { get; set; }
        public string KqclsXquang { get; set; }
        public string KqclsNuocTieu { get; set; }
        public string KqclsXetNghiemKhac { get; set; }
        public string ChanDoanMucDoTha { get; set; }
        public string ChanDoanGiaiDoanTha { get; set; }
        public string ChanDoanBenhPhoiHop { get; set; }
        public string HauTo { get; set; }
    }
}
