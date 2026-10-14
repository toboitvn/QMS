using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LPlayerInfo
    {
        public decimal PlayerId { get; set; }
        public string PlayerCode { get; set; }
        public short PlayerType { get; set; }
        public decimal? MemberId { get; set; }
        public string MemberCode { get; set; }
        public short? CardTypeId { get; set; }
        public string PlayerName { get; set; }
        public string CreateUser { get; set; }
        public string CheckOutUser { get; set; }
        public int StaffId { get; set; }
        public int? SignRateId { get; set; }
        public decimal? SignRate { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal TotalDiscount { get; set; }
        public string SDiscountType { get; set; }
        public decimal? FDiscountRate { get; set; }
        public string PaymentId { get; set; }
        public short PaymentMethodId { get; set; }
        public short Status { get; set; }
        public string CountryId { get; set; }
        public short Sex { get; set; }
        public int? MemberTypeId { get; set; }
        public int? LaneId { get; set; }
        public short? ServiceChargeRate { get; set; }
        public short? VatRate { get; set; }
        public byte? DiscountType { get; set; }
        public string InvoiceNote { get; set; }
        public string BagTag { get; set; }
        public int? DinhDanhCaNhanId { get; set; }
    }
}
