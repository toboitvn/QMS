using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TSoBienBanKiemDiemTuVong
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdBsyDtri { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public string SoHoChieuCmt { get; set; }
        public DateTime? NgayCapHoChieu { get; set; }
        public string NoiCapHoChieu { get; set; }
        public string NoiLamViec { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public DateTime? NgayHienTai { get; set; }
        public string ThanhPhanThamGia { get; set; }
        public string ChuToa { get; set; }
        public string ThuKy { get; set; }
        public string HopTai { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public string NnhanTuVong { get; set; }
        public string TtTienSuBenh { get; set; }
        public string Ttlvv { get; set; }
        public string ChanDoan { get; set; }
        public string TtDienBienBenh { get; set; }
        public string TtQuaTrinhDtri { get; set; }
        public string TtQuaTrinhChamSoc { get; set; }
        public string KdTiepDonNguoiBenh { get; set; }
        public string KdThamKham { get; set; }
        public string KdDieuTri { get; set; }
        public string KdChamSoc { get; set; }
        public string KdMoiQuanHeVoiGdbn { get; set; }
        public string YkienTungNguoi { get; set; }
        public string KetLuan { get; set; }
        public string IpMayTao { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThaiIn { get; set; }
        public int? LanIn { get; set; }
    }
}
