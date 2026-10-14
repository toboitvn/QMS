using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LSupplyUnit
    {
        public short SupplyUnitId { get; set; }
        public string SupplyUnitName { get; set; }
        public int? IntOrder { get; set; }
        public string SDesc { get; set; }
    }
}
