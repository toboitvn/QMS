using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LRanks
    {
        public short RankId { get; set; }
        public string RankCode { get; set; }
        public string RankName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public int? CategoryStatus { get; set; }
    }
}
