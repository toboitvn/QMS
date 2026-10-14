using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongExamExtern
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Quanham { get; set; }
        public string Chucvu { get; set; }
        public string Donvict { get; set; }
        public string Cappc { get; set; }
        public string Thanhphanbay { get; set; }
        public string Loaimaybay { get; set; }
        public DateTime? Ngaygdkeodai { get; set; }
        public string Sobanglai { get; set; }
        public DateTime? Ngaycap { get; set; }
        public DateTime? Ngaygdtren35 { get; set; }
        public DateTime? Ngaydgdinhky { get; set; }
        public bool? Catbay { get; set; }
        public int LoaiKham { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Ipmactao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Ipmacsua { get; set; }
        public string Lydokham { get; set; }
        public string DoituongGiamdinh { get; set; }
    }
}
