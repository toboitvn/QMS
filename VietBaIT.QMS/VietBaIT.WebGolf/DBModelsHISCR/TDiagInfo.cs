using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDiagInfo
    {
        public long DiagId { get; set; }
        public long ExamId { get; set; }
        public int? PatientDeptId { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public string SummarizeInfo { get; set; }
        public string DiagInfo { get; set; }
        public string TreatInfo { get; set; }
        public string MainDiseaseId { get; set; }
        public string AuxiDiseaseId { get; set; }
        public string DifferInfo { get; set; }
        public short DoctorId { get; set; }
        public DateTime DiagDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string KeyCode { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string MoTaBenhChinh { get; set; }
        public string MaBenhYhct { get; set; }
        public string MaBenhYhctPhu { get; set; }
        public string TenbenhYhct { get; set; }
        public string TenbenhYhctPhu { get; set; }
        public int? IdDieuduongphu { get; set; }
    }
}
