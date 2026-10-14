using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlbaMuonTraKhoa
    {
        public int Id { get; set; }
        public int IdHoSo { get; set; }
        public short FromDeptmentId { get; set; }
        public short StaffId { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool? DaTra { get; set; }
        public string GhiChu { get; set; }
    }
}
