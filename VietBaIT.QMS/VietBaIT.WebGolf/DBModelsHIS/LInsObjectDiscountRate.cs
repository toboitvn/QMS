using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LInsObjectDiscountRate
    {
        public int InsObjectCodeNumber { get; set; }
        public int InsObjectId { get; set; }
        public decimal? DiscountRate { get; set; }
        public string DiscountTypeId { get; set; }
        public int? IsSpecialDiscount { get; set; }
        public decimal? Maximum { get; set; }
        public decimal? Minimum { get; set; }
        public string SDesc { get; set; }
    }
}
