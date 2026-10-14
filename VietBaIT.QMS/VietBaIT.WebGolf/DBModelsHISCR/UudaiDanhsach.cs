using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class UudaiDanhsach
    {
        public int IdUudai { get; set; }
        public string MaUudai { get; set; }
        public string TenUudai { get; set; }
        public string MotaUudai { get; set; }
        public DateTime HieulucTungay { get; set; }
        public DateTime HieulucDenngay { get; set; }
        public string DoituongUudai { get; set; }
        public decimal? PhamtramUudai { get; set; }
        public decimal? SotienUudai { get; set; }
        public string Ghichu { get; set; }
        public bool HieuLuc { get; set; }
    }
}
