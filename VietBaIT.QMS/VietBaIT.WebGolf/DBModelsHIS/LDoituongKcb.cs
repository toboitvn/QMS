using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDoituongKcb
    {
        public int IdDoituongKcb { get; set; }
        public string MaDoituongKcb { get; set; }
        public string TenDoituongKcb { get; set; }
        public string TrichDan { get; set; }
        public byte? HienThi { get; set; }
    }
}
