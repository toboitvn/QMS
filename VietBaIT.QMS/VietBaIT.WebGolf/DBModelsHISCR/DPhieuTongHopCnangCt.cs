using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuTongHopCnangCt
    {
        public long IdPhieuThopCnangCt { get; set; }
        public int IdPhieuThopCnang { get; set; }
        public int IdThuoc { get; set; }
        public short IdKho { get; set; }
        public double SoLuong { get; set; }
        public double SoLuongPhat { get; set; }
        public int IdThuocKho { get; set; }
    }
}
