using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongKhamtuyen
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Khuvuc { get; set; }
        public string Uutien { get; set; }
        public string Thanhphan { get; set; }
        public string Masovong2 { get; set; }
        public int? Lankham { get; set; }
        public bool? Doanvien { get; set; }
        public bool? Dangvien { get; set; }
        public bool? Quannhan { get; set; }
        public string Tongiao { get; set; }
        public string Banthan { get; set; }
        public string Bennoi { get; set; }
        public string Benngoai { get; set; }
        public string Bome { get; set; }
        public string Giadinh { get; set; }
        public string Nguoixacminh { get; set; }
        public bool? Vong1 { get; set; }
        public string Ketquavong1 { get; set; }
        public bool? Vong2 { get; set; }
        public string Ketquavong2 { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Ipmactao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Ipmacsua { get; set; }
    }
}
