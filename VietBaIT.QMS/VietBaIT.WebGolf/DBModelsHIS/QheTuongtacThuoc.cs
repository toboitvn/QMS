using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QheTuongtacThuoc
    {
        public string MaHoatchat { get; set; }
        public string MaTuongtac { get; set; }
        public short Loai { get; set; }
        public string CoChe { get; set; }
        public string HauQua { get; set; }
        public string XuTri { get; set; }
        public string MucDo { get; set; }
        public string NoiDung { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
