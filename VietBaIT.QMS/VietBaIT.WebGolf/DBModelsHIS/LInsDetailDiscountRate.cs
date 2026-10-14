using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LInsDetailDiscountRate
    {
        public string ObjectTypeCode { get; set; }
        public int ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public decimal DiscountRate { get; set; }
        public string InsType { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
