using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TLichSuBsdieuTri
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short DoctorId { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public short DepartmentId { get; set; }
        public bool PrimaryPhysician { get; set; }
        public int Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
