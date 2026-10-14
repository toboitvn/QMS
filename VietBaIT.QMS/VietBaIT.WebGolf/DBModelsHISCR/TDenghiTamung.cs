using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDenghiTamung
    {
        public int IdDenghi { get; set; }
        public short KhoaDenghi { get; set; }
        public DateTime NgayDenghi { get; set; }
        public int NguoiDenghi { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string NoiDung { get; set; }
        public string AssignDetailIds { get; set; }
        public decimal SoTien { get; set; }
        public string NoiThu { get; set; }
        public int? TrangThai { get; set; }
        public int? LanIn { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
