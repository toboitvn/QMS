using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlddPhieuHuyBaoAn
    {
        public int IdPhieuHuyBaoAn { get; set; }
        public DateTime? NgayBaoAnHuy { get; set; }
        public short? IdKhoaNoiTru { get; set; }
        public short? IdNhanVien { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public bool? DaDuyet { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public string NguoiDuyet { get; set; }
    }
}
