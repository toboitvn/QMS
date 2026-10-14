using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LCountries
    {
        public short CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryNameEn { get; set; }
        public short CountrySequence { get; set; }
        public bool? IsActive { get; set; }
        public string Nationality { get; set; }
    }
}
