using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TNghiThucMo
    {
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string SoLuu { get; set; }
        public string PthuatVien { get; set; }
        public string TroThuVien { get; set; }
        public string NguoiGmeHsuc { get; set; }
        public string NguoiDcuVien { get; set; }
        public string NguoiCdoanTruocMo { get; set; }
        public string NguoiCdoanMo { get; set; }
        public string NguoiPphapMo { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
