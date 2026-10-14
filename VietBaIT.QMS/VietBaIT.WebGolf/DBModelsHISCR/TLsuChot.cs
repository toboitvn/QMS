using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TLsuChot
    {
        public int IdChot { get; set; }
        public DateTime NgayChot { get; set; }
        public string NguoiChot { get; set; }
        public DateTime? NgayChotTu { get; set; }
        public DateTime? NgayChotDen { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? DaHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string NguoiHuy { get; set; }
    }
}
