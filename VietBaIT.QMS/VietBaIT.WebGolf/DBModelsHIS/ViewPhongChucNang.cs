using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewPhongChucNang
    {
        public long AssignDetailId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public decimal? DiscountPrice { get; set; }
        public double? Quantity { get; set; }
        public double? Tt { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public string BsThucHien { get; set; }
        public string Summary { get; set; }
        public byte? IsPayment { get; set; }
        public string AssignDetailCode { get; set; }
        public byte DaGuiCls { get; set; }
        public byte? AssignDetailStatus { get; set; }
        public byte? NoiTru { get; set; }
        public byte? TrongGoi { get; set; }
        public string TtChuyen { get; set; }
        public string AssignDetailStatusName { get; set; }
        public long AssignId { get; set; }
        public string Barcode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime RegDate { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public short? DepartmentId { get; set; }
        public short? DiagPerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string MaKhoaThien { get; set; }
        public string MaCoSo { get; set; }
        public string ServiceDetailName { get; set; }
        public string StaffName { get; set; }
        public string DepartmentName { get; set; }
        public string ServiceCode { get; set; }
        public byte? ServiceTypeType { get; set; }
        public string InsuranceNum { get; set; }
        public int? EmergencyHos { get; set; }
        public byte? CorrectLine { get; set; }
        public string ObjectTypeName { get; set; }
        public string ObjectTypeCode { get; set; }
        public string ObjectTypeTypeName { get; set; }
        public string PatientAddr { get; set; }
        public string IdentifyNum { get; set; }
        public string PatientName { get; set; }
        public byte PatientSex { get; set; }
        public string SPatientSex { get; set; }
        public short? YearOfBirth { get; set; }
    }
}
