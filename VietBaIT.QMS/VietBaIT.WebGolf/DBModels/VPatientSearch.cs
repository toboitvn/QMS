using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class VPatientSearch
    {
        public long PatientId { get; set; }
        public string Sex { get; set; }
        public DateTime InputDate { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public string IdentifyNum { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientBirth { get; set; }
        public short? YearOfBirth { get; set; }
        public byte PatientSex { get; set; }
        public string SurveyName { get; set; }
        public string PatientAddr { get; set; }
        public string PinputDate { get; set; }
    }
}
