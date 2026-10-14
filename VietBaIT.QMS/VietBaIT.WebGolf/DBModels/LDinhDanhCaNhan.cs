using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LDinhDanhCaNhan
    {
        public int DinhDanhCaNhanId { get; set; }
        public int? DinhDanhCaNhanSequence { get; set; }
        public string DinhDanhCaNhanCode { get; set; }
        public string DinhDanhCaNhanName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public short? YearBirth { get; set; }
        public short? CountryId { get; set; }
        public short? Sex { get; set; }
        public bool? IsUsed { get; set; }
        public string Address { get; set; }
        public DateTime? DinhDanhCaNhanCreatedDate { get; set; }
    }
}
