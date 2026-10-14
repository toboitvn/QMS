using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewThongtinBuonggiuong
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
        public int? IsCancel { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentStatus { get; set; }
        public int? BhytStatus { get; set; }
        public int? NoiTru { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? IsPayment { get; set; }
        public int? PaymentId { get; set; }
        public int? IdKhoaRavien { get; set; }
        public int? TrangThaiRavien { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public int? IdGoiDvu { get; set; }
        public int? TrongGoi { get; set; }
        public int? IdYtaPgiuong { get; set; }
        public DateTime? NgayPgiuong { get; set; }
        public string NguoiPgiuong { get; set; }
        public decimal? SurchargePrice { get; set; }
        public decimal? PhuThuNgoaigoi { get; set; }
        public int? XacNhan { get; set; }
        public string TenHienThi { get; set; }
        public string IpMacSua { get; set; }
        public string IpMacTao { get; set; }
        public int IdBenhLy { get; set; }
        public int IdLoaiBg { get; set; }
        public string BedTypeName { get; set; }
        public string RoomName { get; set; }
        public string BedName { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? PhuThu { get; set; }
        public decimal? Bhct { get; set; }
        public decimal? Bnct { get; set; }
        public string TenLoaiBg { get; set; }
        public string TenBenhLy { get; set; }
        public string TenGoiDvu { get; set; }
        public decimal? Tong { get; set; }
    }
}
