using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class SysThamSoReport
    {
        public string MaBaoCao { get; set; }
        public string TenThamSo { get; set; }
        public string GiaTri { get; set; }
        public bool? TrinhKy { get; set; }
        public bool? BangChu { get; set; }
    }
}
