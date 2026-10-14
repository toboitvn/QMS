using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TempDmKho
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public byte? IdKieukho { get; set; }
        public bool? IsNhapKho { get; set; }
        public short? IdKhoa { get; set; }
        public string LoaiKho { get; set; }
        public string KieuKho { get; set; }
        public string Loaikho1 { get; set; }
        public byte? KhoBan { get; set; }
        public byte? LaTuthuoc { get; set; }
        public string LoaiBn { get; set; }
    }
}
