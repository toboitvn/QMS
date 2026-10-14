using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmHoiChanThanhPhanThamDu
    {
        public int IdThanhPhan { get; set; }
        public int IdSoBienBanHoiChan { get; set; }
        public string HoTen { get; set; }
        public string ChucDanh { get; set; }
        public string ChucVu { get; set; }
        public string DonVi { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
    }
}
