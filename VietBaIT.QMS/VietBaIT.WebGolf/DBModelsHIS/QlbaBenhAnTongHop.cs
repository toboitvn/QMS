using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlbaBenhAnTongHop
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBaNoitru { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public string LoaiBenhAn { get; set; }
    }
}
