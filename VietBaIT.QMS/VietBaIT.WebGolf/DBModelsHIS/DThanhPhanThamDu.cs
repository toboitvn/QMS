using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DThanhPhanThamDu
    {
        public int Id { get; set; }
        public int? IdPhieuNhapTra { get; set; }
        public int? LoaiPhieu { get; set; }
        public string HoTen { get; set; }
        public string ChucDanh { get; set; }
        public string ChucVu { get; set; }
        public string DonVi { get; set; }
    }
}
