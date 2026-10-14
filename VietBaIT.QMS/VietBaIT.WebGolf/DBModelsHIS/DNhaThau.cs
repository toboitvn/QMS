using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DNhaThau
    {
        public short IdNhaThau { get; set; }
        public string MaNhaThau { get; set; }
        public string TenNhaThau { get; set; }
        public short? Stt { get; set; }
        public bool? HienThi { get; set; }
    }
}
