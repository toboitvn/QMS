using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLoadthongtinPhieudieutri
    {
        public int TreatId { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public int? PatientDeptId { get; set; }
        public short? DoctorId { get; set; }
        public short? DepartmentId { get; set; }
        public string Day { get; set; }
        public int? AdditionalStatus { get; set; }
        public string Events { get; set; }
        public byte DaIn { get; set; }
        public string Orders { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public byte? Status { get; set; }
        public DateTime? NurseCreatedDate { get; set; }
        public string NurseCreatedBy { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public string SNgayLapPhieu { get; set; }
        public long? Stt { get; set; }
        public string GioLapPhieu { get; set; }
    }
}
