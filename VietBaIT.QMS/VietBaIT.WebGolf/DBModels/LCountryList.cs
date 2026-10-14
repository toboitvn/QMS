using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LCountryList
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string Desc { get; set; }
        public short IntStt { get; set; }
    }
}
