using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TCoupon
    {
        public int CouponDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int InvoiceDetailId { get; set; }
        public string CouponSerie { get; set; }
        public int? CouponInvoiceDetailId { get; set; }
        public string CouponTypeCode { get; set; }
        public string CouponContent { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime CouponTime { get; set; }
        public decimal CouponProportion { get; set; }
        public decimal ServiceProportion { get; set; }
        public int? CouponId { get; set; }
        public int? CreateBy { get; set; }
    }
}
