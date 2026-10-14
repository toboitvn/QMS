using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuDichTruyen
    {
        public long PhieuTdId { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public long PatientDeptId { get; set; }
        public int? DepartmentId { get; set; }
        public int? BsCd { get; set; }
        public int? YtaThucHien { get; set; }
        public int SoLuong { get; set; }
        public int? DrugId { get; set; }
        public int? TocDo { get; set; }
        public DateTime TgBatDau { get; set; }
        public DateTime TgKetThuc { get; set; }
        public string NguoiThucHien { get; set; }
        public DateTime NgayThucHien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int? PresDetailId { get; set; }
        public bool? DaIn { get; set; }
        public string IdThuocKetHop { get; set; }
    }
}
