using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class GoiDanhsach
    {
        public int IdGoiDvu { get; set; }
        public string MaGoiDvu { get; set; }
        public string TenGoiDvu { get; set; }
        public decimal? TienGoi { get; set; }
        public decimal? MienGiam { get; set; }
        public decimal? GiamtruBhyt { get; set; }
        public DateTime? HieuLucTuNgay { get; set; }
        public DateTime? HieuLucDenNgay { get; set; }
        public bool HieuLuc { get; set; }
    }
}
