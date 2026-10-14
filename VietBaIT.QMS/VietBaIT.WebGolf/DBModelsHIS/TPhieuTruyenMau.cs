using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuTruyenMau
    {
        public string SttRec { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdBsyDtri { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ChanDoan { get; set; }
        public string LoaiChePhamMau { get; set; }
        public string MaSoMau { get; set; }
        public DateTime? NgayLay { get; set; }
        public DateTime? HanDung { get; set; }
        public int? SoLuong { get; set; }
        public string NgayNoiLamXn { get; set; }
        public string AntiHiv { get; set; }
        public string TenSinhPham { get; set; }
        public string KqxnNguoiCho { get; set; }
        public string KqxnBenhNhan { get; set; }
        public string PhanUngCheoOng1 { get; set; }
        public string PhanUngCheoOng2 { get; set; }
        public string TruongKhoaXn { get; set; }
        public string NguoiPhatMau1 { get; set; }
        public string NguoiPhatMau2 { get; set; }
        public string TdtmBschiDinh { get; set; }
        public string TdtmLoaiCpMauTruyen { get; set; }
        public string TdtmMaSoMau { get; set; }
        public DateTime? TdtmHanDung { get; set; }
        public int? TdtmLanTruyen { get; set; }
        public string TdtmNhomMauNguoiCho { get; set; }
        public string TdtmNhomMauBenhNhan { get; set; }
        public string TdtmPhanUngHoaHop { get; set; }
        public int? TdtmLuongMau { get; set; }
        public DateTime? TdtmTgbatDauTruyen { get; set; }
        public DateTime? TdtmTgketThucTruyen { get; set; }
        public string TdtmSoLuongTruyen { get; set; }
        public string SoLuongTruyenThucTe { get; set; }
        public string BsthucHienTm { get; set; }
        public string YtaThucHienTdtm { get; set; }
        public string IpMayTao { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThaiIn { get; set; }
        public int? LanIn { get; set; }
    }
}
