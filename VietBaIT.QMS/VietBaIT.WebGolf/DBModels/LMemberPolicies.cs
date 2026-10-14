using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LMemberPolicies
    {
        public int CardTypeId { get; set; }
        public string ServiceId { get; set; }
        public decimal? DiscountRate { get; set; }
        public short DiscountType { get; set; }
        public string Desc { get; set; }
        public short Status { get; set; }
        public int Id { get; set; }
    }
}
