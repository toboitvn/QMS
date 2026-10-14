using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QheCamchidinhChungphieu
    {
        public int IdDichvu { get; set; }
        public int IdDichvuCamchidinhchung { get; set; }
        public byte Loai { get; set; }
        public string MucTuongtac { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public string HauQua { get; set; }
        public string CachXutri { get; set; }
    }
}
