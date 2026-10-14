using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class VinHospitalPatientInfo
    {
        public string PatientName { get; set; }
        public int? YearOfBirth { get; set; }
        public bool PatientSex { get; set; }
        public string PatientJob { get; set; }
        public string ProvinceName { get; set; }
        public string PatientCode { get; set; }
        public byte HosStatus { get; set; }
        public string ObjectTypeName { get; set; }
        public string InsuranceNum { get; set; }
        public int PatientId { get; set; }
    }
}
