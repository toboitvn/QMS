using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LTaiNanTtich
    {
        public short IdTaiNanTtich { get; set; }
        public string MaTaiNanTtich { get; set; }
        public string TenTaiNanTtich { get; set; }
        public short Stt { get; set; }
        public bool? HienThi { get; set; }
    }
}
