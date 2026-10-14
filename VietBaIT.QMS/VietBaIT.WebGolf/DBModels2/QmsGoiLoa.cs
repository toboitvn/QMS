using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels2
{
    public partial class QmsGoiLoa
    {
        public int Id { get; set; }
        public string SoKham { get; set; }
        public string QuayGoi { get; set; }
        public string MayGoi { get; set; }
        public string MaKhoa { get; set; }
        public byte? TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MayTao { get; set; }
        public string LoaGoi { get; set; }
        public string NoiDung { get; set; }
    }
}
