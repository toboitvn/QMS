using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongLichsubayTainan
    {
        public int DetailId { get; set; }
        public int LichsuId { get; set; }
        public DateTime Thoigian { get; set; }
        public string Diengiai { get; set; }
    }
}
