using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels2
{
    public partial class QmsLoai
    {
        public int Id { get; set; }
        public string NhomQms { get; set; }
        public string LoaiQms { get; set; }
        public string TenQms { get; set; }
        public string GhiChu { get; set; }
        public short SttUutien { get; set; }
        public short? SttHienthi { get; set; }
        public byte? Trangthai { get; set; }
        public string MaKhoa { get; set; }
        public byte? UuTien { get; set; }
        public string MaDoituongKcb { get; set; }
    }
}
