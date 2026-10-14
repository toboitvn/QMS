using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewTAssignDetail
    {
        public long AssignDetailId { get; set; }
        public long? ExamId { get; set; }
        public long AssignId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public short? DiagPerson { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? DiscountType { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string UserId { get; set; }
        public byte? AssignTypeId { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public byte? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsCancel { get; set; }
        public byte? IsPayment { get; set; }
        public short? ObjectTypeId { get; set; }
        public double? Quantity { get; set; }
        public string Summary { get; set; }
        public byte? AssignDetailStatus { get; set; }
        public string SDesc { get; set; }
        public string SPathImage1 { get; set; }
        public string SPathImage2 { get; set; }
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
        public int? PaymentId { get; set; }
        public byte? ComfirmDeposit { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte? TrongGoi { get; set; }
        public string IpMacSua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public byte? ChoPhepIn { get; set; }
        public byte? TtChuyen { get; set; }
        public short? Stt { get; set; }
        public short? IdNoiThien { get; set; }
        public decimal? TyleTt { get; set; }
        public string TenLoaiDvu { get; set; }
        public string ServiceCode { get; set; }
        public short? IntOrderGroup { get; set; }
        public string TenDvu { get; set; }
        public bool? Hiv { get; set; }
        public int? IntOrder { get; set; }
        public string NoiThucHien { get; set; }
    }
}
