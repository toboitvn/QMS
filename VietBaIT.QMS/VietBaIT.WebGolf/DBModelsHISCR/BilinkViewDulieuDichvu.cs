using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BilinkViewDulieuDichvu
    {
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceName { get; set; }
        public int ServiceTypeId { get; set; }
        public long? ExamId { get; set; }
        public int? TreatId { get; set; }
        public DateTime RegDate { get; set; }
        public short? NguoiChidinh { get; set; }
        public short? DepartmentId { get; set; }
        public byte? NoiTru { get; set; }
        public long IdChitiet { get; set; }
        public long IdTh { get; set; }
        public int? ServiceId { get; set; }
        public int IdDv { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public double? ThanhTien { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsPayment { get; set; }
        public double? Quantity { get; set; }
        public int? AssignDetailStatus { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public int? PaymentId { get; set; }
        public byte? TrongGoi { get; set; }
        public byte? DaGuiCls { get; set; }
        public int? ObjectTypeServiceId { get; set; }
        public long? IdThe { get; set; }
        public short ObjectTypeId { get; set; }
        public byte HosStatus { get; set; }
        public byte? ThopStatus { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public int? TongSoNgayDtri { get; set; }
        public string MaLoaiKcb { get; set; }
    }
}
