using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class THeathCare
    {
        public int HeathId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public short? DepartmentId { get; set; }
        public short? StaffId { get; set; }
        public string Events { get; set; }
        public string Reviews { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? NgayDky { get; set; }
        public string GioDky { get; set; }
        public bool? DaIn { get; set; }
        public string Judge { get; set; }
    }
}
