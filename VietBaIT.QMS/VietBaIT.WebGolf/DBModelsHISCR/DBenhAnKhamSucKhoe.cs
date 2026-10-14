using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DBenhAnKhamSucKhoe
    {
        public string SttRec { get; set; }
        public string PatientCode { get; set; }
        public string Bacsyketluan { get; set; }
        public DateTime? Ngaykham { get; set; }
        public string Lydokham { get; set; }
        public string Ghichu { get; set; }
        public string Ketluan { get; set; }
        public string Phanloaisuckhoe { get; set; }
        public string Cacbenhtat { get; set; }
        public bool? TsGiadinh { get; set; }
        public string TsGiadinhGhichu { get; set; }
        public bool? TsBanthan { get; set; }
        public string TsBanthanGhichu { get; set; }
        public string Benhdangdieutri { get; set; }
        public string TsThaisan { get; set; }
        public string NoiTuanhoan { get; set; }
        public string NoiTuanhoanPhanloai { get; set; }
        public string NoiHohap { get; set; }
        public string NoiHohapPhanloai { get; set; }
        public string NoiTieuhoa { get; set; }
        public string NoiTieuhoaPhanloai { get; set; }
        public string NoiThantietnieu { get; set; }
        public string NoiThantietnieuPhanloai { get; set; }
        public string NoiCxk { get; set; }
        public string NoiCxkPhanloai { get; set; }
        public string NoiThankinh { get; set; }
        public string NoiThankinhPhanloai { get; set; }
        public string NoiTamthan { get; set; }
        public string NoiTamthanPhanloai { get; set; }
        public string Ngoaikhoa { get; set; }
        public string NgoaikhoaPhanloai { get; set; }
        public string Sankhoa { get; set; }
        public string SankhoaPhanloai { get; set; }
        public string MatPhaiKk { get; set; }
        public string MatPhaiCk { get; set; }
        public string MatTraiKk { get; set; }
        public string MatTraiCk { get; set; }
        public string MatBenh { get; set; }
        public string MatPhanloai { get; set; }
        public string TmhTraiNthuong { get; set; }
        public string TmhTraiNtham { get; set; }
        public string TmhPhaiNthuong { get; set; }
        public string TmhPhaiNtham { get; set; }
        public string TmhBenh { get; set; }
        public string TmhPhanloai { get; set; }
        public string RhmHamtren { get; set; }
        public string RhmHamduoi { get; set; }
        public string RhmBenh { get; set; }
        public string RhmPhanloai { get; set; }
        public string Dalieu { get; set; }
        public string DalieuPhanloai { get; set; }
        public string XnmauHongcau { get; set; }
        public string XnmauBachcau { get; set; }
        public string XnmauTieucau { get; set; }
        public string XnmauDuongmau { get; set; }
        public string XnmauUre { get; set; }
        public string XnmauCreatinin { get; set; }
        public string XnmauAsat { get; set; }
        public string XnmauAlat { get; set; }
        public string XnmauKhac { get; set; }
        public string XnnuoctieuDuong { get; set; }
        public string XnnuoctieuProtein { get; set; }
        public string XnnuoctieuKhac { get; set; }
        public string Cdha { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public bool? SgBinhthuong { get; set; }
        public bool? SgMumautoanbo { get; set; }
        public bool? SgMumauDo { get; set; }
        public bool? SgMumauXanhla { get; set; }
        public bool? SgMumauVang { get; set; }
        public bool? TsBenhhaybithuongTrong5nam { get; set; }
        public bool? TsBenhthankinhThuongodau { get; set; }
        public bool? TsBenhvemat { get; set; }
        public bool? TsBenhvetai { get; set; }
        public bool? TsBenhotim { get; set; }
        public bool? TsBenhphauthuatCanthieptim { get; set; }
        public bool? TsBenhtanghuyetap { get; set; }
        public bool? TsBenhkhotho { get; set; }
        public bool? TsBenhphoi { get; set; }
        public bool? TsBenhthanLocmau { get; set; }
        public bool? TsBenhdaithaoduong { get; set; }
        public bool? TsBenhtamthan { get; set; }
        public bool? TsBenhmatythuc { get; set; }
        public bool? TsNgatChongmat { get; set; }
        public bool? TsBenhtieuhoa { get; set; }
        public bool? TsRoiloangiacngu { get; set; }
        public bool? TsTaibienmachmaunao { get; set; }
        public bool? TsBenhcotsong { get; set; }
        public bool? TsSudungruouThuongxuyen { get; set; }
        public bool? TsSudungmatuy { get; set; }
        public string HaimatKk { get; set; }
        public string HaimatCk { get; set; }
        public string MatThitruongngangBt { get; set; }
        public string MatThitruongngangHanche { get; set; }
        public string MatThitruongdungBt { get; set; }
        public string MatThitruongdungHanche { get; set; }
        public string Timmach { get; set; }
        public string TimmachPhanloai { get; set; }
        public int? LoaiBa { get; set; }
        public string XnTestmorphinHeroin { get; set; }
        public string XnTestamphetamin { get; set; }
        public string XnTestmethamphetamin { get; set; }
        public string XnTestmarijuana { get; set; }
        public string XnTestnongdocon { get; set; }
        public string XnCdClskhac { get; set; }
        public string XnCdClskhacKetqua { get; set; }
        public string XnCdClskhacKetluan { get; set; }
        public bool? TsNghienruouBia { get; set; }
        public int? Dagui { get; set; }
        public DateTime? Ngaygui { get; set; }
        public string Signdata { get; set; }
        public int IdBenhan { get; set; }
    }
}
