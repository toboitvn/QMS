using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TondauVtNt
    {
        public int? Idthuoc { get; set; }
        public string Tenthuoc { get; set; }
        public decimal? Soluong { get; set; }
        public decimal? Price { get; set; }
        public DateTime? HanDung { get; set; }
        public string Sdk { get; set; }
        public string Solo { get; set; }
        public string Quetdinh { get; set; }
    }
}
