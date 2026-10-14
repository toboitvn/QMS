using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class VPatientExamSearch
    {
        public long PatientId { get; set; }
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
        public DateTime InputDate { get; set; }
        public string UserId { get; set; }
        public byte HosStatus { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? DiscountType { get; set; }
        public decimal? OrgirinMoney { get; set; }
        public decimal? LastMoney { get; set; }
        public string Desc { get; set; }
        public byte? Locked { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string ReasonBy { get; set; }
        public long? IndentityNo { get; set; }
        public string ObjectTypeName { get; set; }
        public string Status { get; set; }
    }
}
