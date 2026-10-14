using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TTheoDoiChiSoSinhTonTruyenMau
    {
        public int Id { get; set; }
        public string SttRec { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? Ngay { get; set; }
        public string Gio { get; set; }
        public string SacMat { get; set; }
        public string NhipTho { get; set; }
        public string NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public string Mach { get; set; }
        public string DienBienKhac { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
