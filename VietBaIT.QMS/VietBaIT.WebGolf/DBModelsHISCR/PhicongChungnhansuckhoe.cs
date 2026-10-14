using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongChungnhansuckhoe
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Sochungnhan { get; set; }
        public DateTime? Ngaychungnhan { get; set; }
        public DateTime? Ngayhethan { get; set; }
        public string Tieuchuan { get; set; }
        public string Tieuchuan2 { get; set; }
        public string Dieukien { get; set; }
        public string Dieukien2 { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Ipmactao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Ipmacsua { get; set; }
    }
}
