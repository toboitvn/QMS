using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DQuyCach
    {
        public short IdQuyCach { get; set; }
        public string MaQuyCach { get; set; }
        public string TenQuyCach { get; set; }
        public short? Stt { get; set; }
        public bool? HienThi { get; set; }
    }
}
