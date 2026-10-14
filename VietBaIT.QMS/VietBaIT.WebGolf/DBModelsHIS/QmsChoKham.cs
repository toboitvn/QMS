using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QmsChoKham
    {
        public int RegId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? InputDate { get; set; }
        public short? DepartmentId { get; set; }
        public short? DoctorAssignId { get; set; }
        public byte? Status { get; set; }
        public short? SoKham { get; set; }
        public string MaKhoaThien { get; set; }
        public string MaPhongStt { get; set; }
        public string MaCoSo { get; set; }
        public int? ExamId { get; set; }
        public byte? HienThi { get; set; }
        public bool? QmsHienThi { get; set; }
    }
}
