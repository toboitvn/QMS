using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TTralaiTtoan
    {
        public int IdChitiet { get; set; }
        public int? PaymentId { get; set; }
        public int? Quanity { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? SurchargePrice { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public int? PaymentTypeId { get; set; }
        public decimal? PtramBh { get; set; }
        public string ServiceDetailName { get; set; }
        public string DonViTinh { get; set; }
        public string MaKieuTtoan { get; set; }
        public string MaDv { get; set; }
        public int? IsPayment { get; set; }
        public int? IdPhieu { get; set; }
        public int? IdPhieuCtiet { get; set; }
    }
}
