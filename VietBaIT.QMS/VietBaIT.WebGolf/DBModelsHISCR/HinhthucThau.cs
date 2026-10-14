using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class HinhthucThau
    {
        public int IdHinhthuc { get; set; }
        public string TenHinhthuc { get; set; }
        public bool? ConSudung { get; set; }
        public string MaHinhthuc { get; set; }
    }
}
