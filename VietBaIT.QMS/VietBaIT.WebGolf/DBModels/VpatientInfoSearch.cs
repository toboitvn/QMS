using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class VpatientInfoSearch
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime InputDate { get; set; }
        public byte HosStatus { get; set; }
        public string PatientName { get; set; }
        public bool PatientSex { get; set; }
        public int? PatientYob { get; set; }
        public DateTime? PatientDob { get; set; }
        public string PatientAddr { get; set; }
        public string PatientJob { get; set; }
        public bool? PaymentStatus { get; set; }
        public short ObjectTypeId { get; set; }
        public string ObjectTypeName { get; set; }
        public string InsurranceNum { get; set; }
    }
}
