using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysReport
    {
        public string MaBaoCao { get; set; }
        public string MoTa { get; set; }
        public string TenFileMacDinh { get; set; }
        public string TenFileRieng { get; set; }
        public string MaNhom { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string TieuDeBcao { get; set; }
        public bool? ThamSo { get; set; }
        public byte[] ChuKy { get; set; }
    }
}
