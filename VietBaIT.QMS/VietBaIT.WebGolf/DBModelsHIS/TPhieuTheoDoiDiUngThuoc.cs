using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuTheoDoiDiUngThuoc
    {
        public long Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public int? IdBsyDtri { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public string NhomMau { get; set; }
        public string ChanDoanChinh { get; set; }
        public string DiUngThuoc { get; set; }
        public string KieuDiUng { get; set; }
        public string BenhKemTheo { get; set; }
        public string IpMayTao { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThaiIn { get; set; }
        public int? LanIn { get; set; }
    }
}
