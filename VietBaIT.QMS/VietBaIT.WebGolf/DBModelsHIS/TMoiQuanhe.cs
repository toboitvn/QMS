using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TMoiQuanhe
    {
        public int Id { get; set; }
        public long PatientId { get; set; }
        public long PatientIdR { get; set; }
        public string PatientCode { get; set; }
        public string PatientCodeR { get; set; }
        public string MoiQuanhe { get; set; }
        public byte TrangThai { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string IpMaytao { get; set; }
        public string IpMaysua { get; set; }
        public string MacTao { get; set; }
        public string MacSua { get; set; }
    }
}
