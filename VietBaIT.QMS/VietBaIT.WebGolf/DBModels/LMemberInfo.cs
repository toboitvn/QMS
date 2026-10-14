using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LMemberInfo
    {
        public decimal MemberId { get; set; }
        public string MemberCode { get; set; }
        public int CardTypeId { get; set; }
        public string MemberName { get; set; }
        public string CountryId { get; set; }
        public short Sex { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ImagePath { get; set; }
        public DateTime? MemberDob { get; set; }
        public short? MemberYob { get; set; }
        public string MemberPhone { get; set; }
        public string MemberAddress { get; set; }
        public string MemberEmail { get; set; }
        public string MemberNationalId { get; set; }
        public string MemberLoyaltyNumber { get; set; }
        public int? DinhDanhCaNhanId { get; set; }
    }
}
