using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBienBanKiemThaoTuVong
    {
        public string SttRec { get; set; }
        public string PatientCode { get; set; }
        public DateTime? NgayKiemThao { get; set; }
        public string Khoa { get; set; }
        public string ChuToa { get; set; }
        public string ThuKy { get; set; }
        public string DienBien { get; set; }
        public string KetLuan { get; set; }
        public string CdTuvong { get; set; }
        public string CdGiaiphau { get; set; }
        public string NhanxetChuanbi { get; set; }
    }
}
