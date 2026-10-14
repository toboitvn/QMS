using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LCardTypeList
    {
        public short CardTypeId { get; set; }
        public string CardTypeName { get; set; }
        public string Desc { get; set; }
        public short Status { get; set; }
        public int? MemberTypeId { get; set; }
    }
}
