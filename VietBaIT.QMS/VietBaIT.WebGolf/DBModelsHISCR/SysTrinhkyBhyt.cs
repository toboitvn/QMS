using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysTrinhkyBhyt
    {
        public string TenForm { get; set; }
        public string TenUser { get; set; }
        public string TenTrinhky { get; set; }
        public int? IdNhanvien { get; set; }
        public string NoiDung { get; set; }
        public int? KieuKy { get; set; }
    }
}
