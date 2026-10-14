using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysNghiomMau
    {
        public int Id { get; set; }
        public string MauNghiom { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string SerieHientai { get; set; }
        public string MaCoso { get; set; }
        public bool? KhoaLai { get; set; }
        public long? IdMau { get; set; }
    }
}
