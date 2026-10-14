using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TWebXacthuc
    {
        public string DienThoai { get; set; }
        public string MaLuotkham { get; set; }
        public long IdBenhnhan { get; set; }
        public string MatKhau { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
