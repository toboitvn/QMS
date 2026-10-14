using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewTimKiemThamKham
    {
        public long RegId { get; set; }
        public string MaKhoaThien { get; set; }
        public byte? PaymentStatus { get; set; }
        public decimal RegFee { get; set; }
        public short? DepartmentId { get; set; }
        public short? SoKham { get; set; }
        public string ObjectTypeCode { get; set; }
        public int PaymentTypeId { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short ObjectTypeId { get; set; }
        public byte HosTrans { get; set; }
        public string RelativeName { get; set; }
        public string RelativePhone { get; set; }
        public string RelativeAddress { get; set; }
        public string InsuranceNum { get; set; }
        public DateTime? InsuranceFromDate { get; set; }
        public DateTime? InsuranceToDate { get; set; }
        public string InsuranceSupply { get; set; }
        public string InsClinicCode { get; set; }
        public string InsObjectCode { get; set; }
        public int? InsObjectCodeNumber { get; set; }
        public string InsObjectCodeTp { get; set; }
        public byte HosStatus { get; set; }
        public decimal? SalaryBasic { get; set; }
        public int? EmergencyHos { get; set; }
        public string Symptoms { get; set; }
        public byte? CorrectLine { get; set; }
        public string MbenhChinh { get; set; }
        public string MbenhPhu { get; set; }
        public string MedicalNumber { get; set; }
        public int? TongSoNgayDtri { get; set; }
        public string MaDoiTuong { get; set; }
        public byte? ThopStatus { get; set; }
        public byte? KieuBn { get; set; }
        public int? IdKhoaTnhan { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public string SCreateDate { get; set; }
        public short? SDepartmentId { get; set; }
        public int? ExamId { get; set; }
        public string PatientName { get; set; }
        public string PatientAddr { get; set; }
        public DateTime? PatientBirth { get; set; }
        public short? YearOfBirth { get; set; }
        public byte PatientSex { get; set; }
        public string PatientJob { get; set; }
        public string Offices { get; set; }
        public string IdentifyNum { get; set; }
        public short? CountryId { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public string SoTheBn { get; set; }
        public short? LoaiTuoi { get; set; }
        public string Age { get; set; }
        public byte? Status { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? RegDate { get; set; }
        public string ObjectTypeName { get; set; }
        public string TenLanKham { get; set; }
        public string MaLanKham { get; set; }
        public int TrongGoi { get; set; }
        public string MaCoSo { get; set; }
        public short? FromDepartmentId { get; set; }
    }
}
