using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DDoituongKho
    {
        public string MaDoiTuong { get; set; }
        public int IdKho { get; set; }
        public int? ThuTu { get; set; }
    }
}
