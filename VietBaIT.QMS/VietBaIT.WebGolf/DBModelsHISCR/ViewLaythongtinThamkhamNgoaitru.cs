using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewLaythongtinThamkhamNgoaitru
    {
        public long RegId { get; set; }
        public byte? PaymentStatus { get; set; }
        public short? SoKham { get; set; }
        public string ObjectTypeCode { get; set; }
        public int PaymentTypeId { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short ObjectTypeId { get; set; }
        public DateTime? InsuranceToDate { get; set; }
        public string InsObjectCode { get; set; }
        public DateTime InputDate { get; set; }
        public byte HosStatus { get; set; }
        public string ReasonBy { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? SalaryBasic { get; set; }
        public int? RankId { get; set; }
        public int? UnitId { get; set; }
        public int? EmergencyHos { get; set; }
        public int? ToHos { get; set; }
        public string PositionName { get; set; }
        public string Symptoms { get; set; }
        public byte? CorrectLine { get; set; }
        public int? FromClinicStatus { get; set; }
        public string ToClinicCode { get; set; }
        public byte? KetQuaDt { get; set; }
        public string MbenhChinh { get; set; }
        public string MbenhPhu { get; set; }
        public string ThueMaso { get; set; }
        public string ThueCongty { get; set; }
        public string GhiChuCv { get; set; }
        public byte DisplayOnReport { get; set; }
        public string MedicalNumber { get; set; }
        public int? TongSoNgayDtri { get; set; }
        public string MaDoiTuong { get; set; }
        public byte? ThopStatus { get; set; }
        public byte? KieuBn { get; set; }
        public byte? DaKhoatGoi { get; set; }
        public int? IdKhoaTnhan { get; set; }
        public int? IdRavien { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public int? IdGoiDvu { get; set; }
        public int? DaSinh { get; set; }
        public int? IdBenhly { get; set; }
        public int? NgoaiThanh { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMacSua { get; set; }
        public string SCreateDate { get; set; }
        public short? SDepartmentId { get; set; }
        public int? ExamId { get; set; }
        public string SPatientSex { get; set; }
        public string PatientName { get; set; }
        public string PatientAddr { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public DateTime? PatientBirth { get; set; }
        public short? YearOfBirth { get; set; }
        public byte PatientSex { get; set; }
        public string PatientJob { get; set; }
        public string Offices { get; set; }
        public string IdentifyNum { get; set; }
        public short? CountryId { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public byte? Locked { get; set; }
        public string DeleteUserBy { get; set; }
        public DateTime? DeleteDateBy { get; set; }
        public string DeleteReasonBy { get; set; }
        public short? DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        public byte? TtHonNhan { get; set; }
        public string HosStatusName { get; set; }
        public int? Age { get; set; }
        public byte? Status { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? RegDate { get; set; }
        public string ObjectTypeName { get; set; }
        public string TenLanKham { get; set; }
        public string MaLanKham { get; set; }
        public int TrongGoi { get; set; }
        public string TenGoiDvu { get; set; }
    }
}
