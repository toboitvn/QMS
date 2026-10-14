using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPatientDept
    {
        public long PatientDeptId { get; set; }
        public long PatientId { get; set; }
        public int? FromDepartmentId { get; set; }
        public short DepartmentId { get; set; }
        public string PatientCode { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public byte? BedType { get; set; }
        public byte Status { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? DoctorAssignId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public byte? IsCancel { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? PaymentStatus { get; set; }
        public byte? BhytStatus { get; set; }
        public byte? NoiTru { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? SurchargePrice { get; set; }
        public byte? IsPayment { get; set; }
        public int? PaymentId { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? TrongGoi { get; set; }
        public int? IdYtaPgiuong { get; set; }
        public DateTime? NgayPgiuong { get; set; }
        public string NguoiPgiuong { get; set; }
        public byte? XacNhan { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public short? IdLoaiBg { get; set; }
        public int? PkPatientdeptId { get; set; }
        public decimal? GiaBnct { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public bool? TrangThaiRavien { get; set; }
        public short? IdKhoaRavien { get; set; }
        public string IpMacSua { get; set; }
        public string IpMaySua { get; set; }
        public long? IdThe { get; set; }
        public decimal? TyleTt { get; set; }
        public decimal? MienGiam { get; set; }
        public int? NamGhep { get; set; }
        public int? TreatId { get; set; }

        public virtual LDepartments Department { get; set; }
    }
}
