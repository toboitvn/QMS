using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TFileInfo
    {
        public long IdFile { get; set; }
        public long? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string SoPhieu { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }
        public int? SttHienthi { get; set; }
        public byte? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string DuongDan { get; set; }
        public string IpMaytao { get; set; }
        public string IpMactao { get; set; }
    }
}
