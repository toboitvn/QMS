using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels2
{
    public partial class QmsPhongBan
    {
        public short IdPhong { get; set; }
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public short Stt { get; set; }
        public byte? HienThi { get; set; }
        public string TenBs { get; set; }
        public byte? UuTien { get; set; }
        public string SoPhong { get; set; }
        public string MaKhoa { get; set; }
        public short? ThoiGianCho { get; set; }
        public string Motathem { get; set; }
        public string MaChucnang { get; set; }
    }
}
