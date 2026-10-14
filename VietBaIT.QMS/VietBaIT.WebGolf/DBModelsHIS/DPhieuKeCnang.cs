using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DPhieuKeCnang
    {
        public int IdPhieuKeCnang { get; set; }
        public DateTime NgayPhieuKeCnang { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public int AssignDetailId { get; set; }
        public int ServiceDetailId { get; set; }
        public short IdKho { get; set; }
        public short IdKhoa { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool DaDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string GhiChu { get; set; }

        public virtual LServiceDetail ServiceDetail { get; set; }
    }
}
