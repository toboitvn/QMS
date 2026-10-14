using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LCoupon
    {
        public int CouponId { get; set; }
        public string CouponPrefix { get; set; }
        public int CouponStartIdx { get; set; }
        public int CouponEndIdx { get; set; }
        public string CouponFullName { get; set; }
        public string CouponPhone { get; set; }
        public int? MemberId { get; set; }
        public int PlayerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime SaleDate { get; set; }
        public int? SaleBy { get; set; }
        public string CouponNote { get; set; }
    }
}
