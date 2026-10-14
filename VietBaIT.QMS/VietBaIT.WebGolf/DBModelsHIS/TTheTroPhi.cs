using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TTheTroPhi
    {
        public int Idthe { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short ObjectTypeId { get; set; }
        public byte DiscountRate { get; set; }
        public string InsuranceNum { get; set; }
        public DateTime? InsuranceFromDate { get; set; }
        public DateTime? InsuranceToDate { get; set; }
        public string InsObjectCode { get; set; }
        public string InsObjectCodeTp { get; set; }
        public string InsClinicCode { get; set; }
        public bool? HosTrans { get; set; }
        public bool? IsDungTuyen { get; set; }
        public bool? GiayBhyt { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
    }
}
