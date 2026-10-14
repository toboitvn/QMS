using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QheTuongtacLog
    {
        public int IdLog { get; set; }
        public int PresId { get; set; }
        public int PresdetailId { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public byte Loai { get; set; }
        public string MaHoatchat { get; set; }
        public string MaTuongtac { get; set; }
        public string NoidungCanhbao { get; set; }
        public string NoidungDongy { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string GuiId { get; set; }
    }
}
