using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class UudaiChitiet
    {
        public int IdUudaiChitiet { get; set; }
        public int IdUudai { get; set; }
        public int ServiceDetailId { get; set; }
        public string ServiceDetailName { get; set; }
        public short LoaiDv { get; set; }
        public short SoLuong { get; set; }
    }
}
