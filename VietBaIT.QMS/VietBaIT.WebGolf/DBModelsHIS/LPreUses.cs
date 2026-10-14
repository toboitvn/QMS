using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LPreUses
    {
        public int UseId { get; set; }
        public string UseName { get; set; }
        public int? IntOrder { get; set; }
        public string SDesc { get; set; }
    }
}
