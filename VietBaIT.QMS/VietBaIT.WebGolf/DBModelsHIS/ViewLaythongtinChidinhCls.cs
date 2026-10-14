using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLaythongtinChidinhCls
    {
        public long AssignDetailId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? DiscountType { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string UserId { get; set; }
        public byte? AssignTypeId { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsPayment { get; set; }
        public int? Quantity { get; set; }
        public string Summary { get; set; }
        public string SDesc { get; set; }
        public byte? BhytStatus { get; set; }
        public string Proposal { get; set; }
        public string VungKs { get; set; }
        public string BsThucHien { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public string AssignDetailCode { get; set; }
        public int? TestId { get; set; }
        public byte DisplayOnReport { get; set; }
        public string GhiChu { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public byte? XacNhan { get; set; }
        public bool? TtChuyen { get; set; }
        public int? PaymentId { get; set; }
        public byte? ComfirmDeposit { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? TrongGoi { get; set; }
        public int IsLocked { get; set; }
        public int IsNew { get; set; }
        public long AssignId { get; set; }
        public long? ExamId { get; set; }
        public int? TreatId { get; set; }
        public int? PatientDeptId { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime RegDate { get; set; }
        public short? DiagPerson { get; set; }
        public short? DepartmentId { get; set; }
        public byte? AssignStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string AssignCode { get; set; }
        public string Barcode { get; set; }
        public short? ObjectTypeId { get; set; }
        public byte? NoiTru { get; set; }
        public short? IdNoiThien { get; set; }
        public byte? IsPhiDvuKtheo { get; set; }
        public bool? Hiv { get; set; }
        public string ServiceDetailName { get; set; }
        public int? SIntOrder { get; set; }
        public string ServiceName { get; set; }
        public short? GroupIntOrder { get; set; }
        public string StaffName { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? Tt { get; set; }
        public byte AssignDetailStatus { get; set; }
        public string NoiThucHien { get; set; }
    }
}
