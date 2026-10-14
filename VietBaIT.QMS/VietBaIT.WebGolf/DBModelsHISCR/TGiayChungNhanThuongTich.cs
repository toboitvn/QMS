using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TGiayChungNhanThuongTich
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? IdBsyDtri { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public DateTime? NgayCapHoKhau { get; set; }
        public DateTime? NgayVv { get; set; }
        public DateTime? NgayRv { get; set; }
        public string CmndHokhau { get; set; }
        public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        public string NoiCapHoKhau { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Ldvv { get; set; }
        public string ChanDoan { get; set; }
        public string DieuTri { get; set; }
        public string TrangThaiTtvv { get; set; }
        public string TrangThaiTtrv { get; set; }
        public string IpMayTao { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThaiIn { get; set; }
        public int? LanIn { get; set; }
        public string SoChungnhan { get; set; }
    }
}
