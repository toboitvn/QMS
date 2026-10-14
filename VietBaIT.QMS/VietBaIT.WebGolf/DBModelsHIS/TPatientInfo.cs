using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPatientInfo
    {
        public int PatientId { get; set; }
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
        public DateTime InputDate { get; set; }
        public string UserId { get; set; }
        public byte? Locked { get; set; }
        public string DeleteUserBy { get; set; }
        public DateTime? DeleteDateBy { get; set; }
        public string DeleteReasonBy { get; set; }
        public short? DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        public byte? TtHonNhan { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public string TenKhongDau { get; set; }
        public string DiaChiBn { get; set; }
        public string SoLo { get; set; }
        public string FirstLetter { get; set; }
        public DateTime? NgayCapCmt { get; set; }
        public string NoiCapCmt { get; set; }
        public string SoTheBn { get; set; }
        public int? Transactionid { get; set; }
        public string MaSthue { get; set; }
        public string WardsId { get; set; }
        public int? CrmCustomerId { get; set; }
        public string BloodTypeAbo { get; set; }
        public string BloodTypeRh { get; set; }
        public string Passport { get; set; }
        public string SoCmtqn { get; set; }
        public int? IdNghenghiep { get; set; }
        public int? IdQuoctich { get; set; }
        public string MaHosoYte { get; set; }
    }
}
