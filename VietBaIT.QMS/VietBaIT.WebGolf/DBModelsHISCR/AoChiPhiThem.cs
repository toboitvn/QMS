using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class AoChiPhiThem
    {
        public int SoPhieu { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public decimal? SoTien { get; set; }
        public string LyDo { get; set; }
        public short? StaffId { get; set; }
        public short? DepartmentId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? PaymentId { get; set; }
        public byte? NoiTru { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? NgayDky { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public decimal? PtramBhyt { get; set; }
        public string GhiChu { get; set; }
        public byte? IsPayment { get; set; }
        public short? ObjectTypeId { get; set; }
        public short? ServiceId { get; set; }
        public short? ServiceDetailId { get; set; }
        public string MaKhoaThien { get; set; }
        public double? SoLuong { get; set; }
        public short? HtThanhtoan { get; set; }
        public byte? DaChot { get; set; }
        public DateTime? NgayChot { get; set; }
        public string NguoiChot { get; set; }
        public string MaCoSo { get; set; }
        public bool? IsCancel { get; set; }
        public bool? TrongGoi { get; set; }
        public bool? XacNhan { get; set; }
        public decimal? MienGiam { get; set; }
    }
}
