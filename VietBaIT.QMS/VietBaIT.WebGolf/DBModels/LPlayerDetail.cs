using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LPlayerDetail
    {
        public decimal PlayerDetailId { get; set; }
        public decimal PlayerId { get; set; }
        public string ServiceId { get; set; }
        public DateTime ServiceTime { get; set; }
        public string PlayerCode { get; set; }
        public decimal? MemberId { get; set; }
        public string MemberCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? DiscountRate { get; set; }
        public short? DiscountType { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public short? NmrFromTime { get; set; }
        public short? NmrToTime { get; set; }
        public int? CreateDate { get; set; }
        public DateTime? InputDate { get; set; }
        public string CreateBy { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? CreateByStaffId { get; set; }
        public string CouponSerie { get; set; }
    }
}
