using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class Chinhsuahanthau
    {
        public double? IdThau { get; set; }
        public string SoThau { get; set; }
        public string SoQdinh { get; set; }
        public double? GoiThau { get; set; }
        public double? NhomThau { get; set; }
        public string TenNhaCcap { get; set; }
        public DateTime? NgayThau { get; set; }
        public string NgaythauDen { get; set; }
        public DateTime? NgayQdinh { get; set; }
        public string NgayqdDen { get; set; }
    }
}
