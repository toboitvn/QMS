using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TRegExamBackup
    {
        public long RegId { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public decimal RegFee { get; set; }
        public byte PaymentStatus { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? InputDate { get; set; }
        public string UserId { get; set; }
        public decimal? SurchargePrice { get; set; }
        public short? DepartmentId { get; set; }
        public short? DoctorAssignId { get; set; }
        public byte? Actived { get; set; }
        public byte? PrintId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public byte? Status { get; set; }
        public int? ExamId { get; set; }
        public byte? IsCancel { get; set; }
        public short? SoKham { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public DateTime? PaymentDate { get; set; }
        public short? FromDepartmentId { get; set; }
        public byte? NoiTru { get; set; }
        public byte? XacNhan { get; set; }
        public int? PaymentId { get; set; }
        public short? IdBsyThien { get; set; }
        public int? IdGoiDvu { get; set; }
        public string KieuKhambenh { get; set; }
        public int? TrongGoi { get; set; }
        public string IpMacSua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public string MaKhoaThien { get; set; }
        public short? IdPhongChuyen { get; set; }
        public byte? IsPayment { get; set; }
        public DateTime? NgayChuyenPhong { get; set; }
        public string NguoiChuyenPhong { get; set; }
        public byte? TtChuyen { get; set; }
        public byte? IsNgoaiGio { get; set; }
        public byte? KhamNgoaigio { get; set; }
        public string MaPhongStt { get; set; }
        public string MaCoSo { get; set; }
        public short? IdLanKham { get; set; }
        public decimal? MienGiam { get; set; }
        public long? IdThe { get; set; }
        public decimal? TyleTt { get; set; }
    }
}
