using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LDrivingLane
    {
        public int LaneId { get; set; }
        public int FloorId { get; set; }
        public string LaneName { get; set; }
        public short? LaneIntOrder { get; set; }
        public decimal? LaneOrderId { get; set; }
        public decimal? PlayerId { get; set; }
    }
}
