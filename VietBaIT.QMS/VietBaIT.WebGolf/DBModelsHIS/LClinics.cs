using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LClinics
    {
        public int ClinicId { get; set; }
        public string SurveyCode { get; set; }
        public string InsClinicCode { get; set; }
        public string ClinicName { get; set; }
        public short? IntOrder { get; set; }
        public string SDesc { get; set; }
        public string Address { get; set; }
        public string MaTuyen { get; set; }
        public string Tuyen { get; set; }
        public string MaHang { get; set; }
        public string Hang { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
