using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewLaythongtinXetnghiem
    {
        public string InsuranceNum { get; set; }
        public string ToInsuranceDate { get; set; }
        public string ObjectTypeCode { get; set; }
        public byte? CorrectLine { get; set; }
        public string PatientName { get; set; }
        public string PatientAddr { get; set; }
        public short? YearOfBirth { get; set; }
        public string PatientBirth { get; set; }
        public string SPatientSex { get; set; }
        public int? Age { get; set; }
        public string DepartmentName { get; set; }
        public string StaffName { get; set; }
        public long AssignDetailId { get; set; }
        public long? ExamId { get; set; }
        public long AssignId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public short? DiagPerson { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? DiscountType { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string UserId { get; set; }
        public byte? AssignTypeId { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsPayment { get; set; }
        public short? ObjectTypeId { get; set; }
        public double? Quantity { get; set; }
        public string Summary { get; set; }
        public byte? AssignDetailStatus { get; set; }
        public string SDesc { get; set; }
        public string SPathImage1 { get; set; }
        public string SPathImage2 { get; set; }
        public byte? BhytStatus { get; set; }
        public string Proposal { get; set; }
        public string VungKs { get; set; }
        public string BsThucHien { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public string AssignDetailCode { get; set; }
        public int? TestId { get; set; }
        public byte DisplayOnReport { get; set; }
        public string GhiChu { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public byte? XacNhan { get; set; }
        public int? PaymentId { get; set; }
        public byte? ComfirmDeposit { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? TrongGoi { get; set; }
        public string PatientCode { get; set; }
        public byte? NoiTru { get; set; }
        public int Tt { get; set; }
        public string ServiceName { get; set; }
        public short? IntOrder { get; set; }
        public string ServiceDetailName { get; set; }
    }
}
