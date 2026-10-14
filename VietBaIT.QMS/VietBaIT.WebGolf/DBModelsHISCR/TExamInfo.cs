using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TExamInfo
    {
        public long ExamId { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Reason { get; set; }
        public short? DiseaseTypeId { get; set; }
        public short? DayDiseases { get; set; }
        public string TreatProfile { get; set; }
        public string DiseaseProfile { get; set; }
        public string FamilyProfile { get; set; }
        public string OtherInfo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FreeDate { get; set; }
        public int? DeptPatientId { get; set; }
        public DateTime? FreeStartDate { get; set; }
        public string KetLuan { get; set; }
        public int? ExamType { get; set; }
        public string ChuY { get; set; }
        public string TienLuong { get; set; }
        public string HuongDieuTri { get; set; }
        public string QtBenhLyDbCls { get; set; }
        public string TomTatKqCls { get; set; }
        public string PhuongPhapDt { get; set; }
        public string TinhTrangRv { get; set; }
        public string HuongDtCheDoTiepTheo { get; set; }
        public int? IdBsyCdinh { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public int? SoNgay { get; set; }
        public bool? KhoaGiayHen { get; set; }
        public string NgayTuvong { get; set; }
        public string ThoigianTuvong { get; set; }
    }
}
