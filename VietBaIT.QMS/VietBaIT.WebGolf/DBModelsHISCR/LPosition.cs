using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LPosition
    {
        public int PostionId { get; set; }
        public string PositionName { get; set; }
        public int? IntOrder { get; set; }
        public string SDesc { get; set; }
    }
}
