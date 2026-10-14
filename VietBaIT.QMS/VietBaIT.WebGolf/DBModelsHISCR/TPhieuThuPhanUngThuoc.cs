using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuThuPhanUngThuoc
    {
        public long IdPhieuThu { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public long? PatientDeptId { get; set; }
        public int? DepartmentId { get; set; }
        public string BsCd { get; set; }
        public string BsDocKiemtra { get; set; }
        public DateTime? NgayDocKiemtra { get; set; }
        public string NguoiThu { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public long? PresDetailId { get; set; }
        public bool? DaIn { get; set; }
        public string PhuongPhapThu { get; set; }
    }
}
