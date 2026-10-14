using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DsXml130
    {
        public double? PatientCode { get; set; }
        public double? PatientId { get; set; }
        public string PatientName { get; set; }
        public double? YearOfBirth { get; set; }
        public string SPatientSex { get; set; }
        public string InsuranceNum { get; set; }
        public DateTime? InsuranceFromDate { get; set; }
        public DateTime? InsuranceToDate { get; set; }
        public double? MaDkkcb { get; set; }
        public double? NoiTru { get; set; }
        public DateTime? Ngayvaovien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public string TrangThai { get; set; }
        public double? IsTonTai { get; set; }
        public double? GuiXml { get; set; }
        public double? DiscountRate { get; set; }
        public double? TienGoc { get; set; }
        public double? TienBhct { get; set; }
        public double? TienBnct { get; set; }
    }
}
