using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LaythongtinPhieuCdXetnghiem
    {
        public long AssignId { get; set; }
        public long? ExamId { get; set; }
        public int? TreatId { get; set; }
        public int? PatientDeptId { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public short? ServiceId { get; set; }
        public short? ServiceTypeId { get; set; }
        public DateTime RegDate { get; set; }
        public short? DiagPerson { get; set; }
        public short? DepartmentId { get; set; }
        public byte? AssignStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AssignCode { get; set; }
        public byte? Actived { get; set; }
        public byte? PrintId { get; set; }
        public byte? SendId { get; set; }
        public string Barcode { get; set; }
        public short? ObjectTypeId { get; set; }
        public byte NoiTru { get; set; }
        public string PatientName { get; set; }
        public short? BirthYear { get; set; }
        public short? YearOfBirth { get; set; }
        public byte? PatientSex { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? PatientBirth { get; set; }
        public string PatientAddr { get; set; }
        public string TenDoiTuong { get; set; }
        public string MaDtuong { get; set; }
        public byte IsDungTuyen { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
    }
}
