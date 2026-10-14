using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmBienbanCamketSudungdichvu
    {
        public int Idphongmo { get; set; }
        public DateTime Ngaylamdon { get; set; }
        public string Nguoilamdon { get; set; }
        public string Quanhe { get; set; }
        public int? Khoa { get; set; }
        public string Dichvu { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
    }
}
