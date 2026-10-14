using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LQuanHam
    {
        public short IdQuanHam { get; set; }
        public string MaQuanHam { get; set; }
        public string TenQuanHam { get; set; }
        public short? Stt { get; set; }
        public byte? HienThi { get; set; }
        public string NhomQuan { get; set; }
    }
}
