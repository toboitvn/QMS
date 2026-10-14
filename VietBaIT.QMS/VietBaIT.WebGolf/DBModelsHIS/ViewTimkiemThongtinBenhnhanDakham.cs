using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewTimkiemThongtinBenhnhanDakham
    {
        public string SPatientSex { get; set; }
        public long PatientId { get; set; }
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
        public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        public byte? TtHonNhan { get; set; }
    }
}
