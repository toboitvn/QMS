using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TXutriCapcuu
    {
        public int IdXutri { get; set; }
        public int IdPhieukhamcapcuu { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Ipmaytao { get; set; }
        public string Nguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Ipmaysua { get; set; }
        public DateTime? Ngaygio { get; set; }
        public string Nhietdo { get; set; }
        public string Mach { get; set; }
        public string Huyetap { get; set; }
        public string Nhiptho { get; set; }
        public string Dienbien { get; set; }
        public string KetquaLamsang { get; set; }
        public string KetquaPhilamsang { get; set; }
        public string GhichepThuthuat { get; set; }
        public string MenhlenhDieutri { get; set; }
    }
}
