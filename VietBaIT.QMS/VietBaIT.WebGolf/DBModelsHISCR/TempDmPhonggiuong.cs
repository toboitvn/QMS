using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TempDmPhonggiuong
    {
        public double? Stt { get; set; }
        public string MaPhong { get; set; }
        public string Phong { get; set; }
        public string MaGiuong { get; set; }
        public string Giuong { get; set; }
        public string Khoa { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoomId { get; set; }
        public int? IdLoaiBg { get; set; }
        public int? BedId { get; set; }
    }
}
