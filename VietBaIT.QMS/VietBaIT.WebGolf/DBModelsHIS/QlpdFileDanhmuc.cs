using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlpdFileDanhmuc
    {
        public int Id { get; set; }
        public int? IdPhacdo { get; set; }
        public string FileName { get; set; }
        public byte[] DataFile { get; set; }
        public string GhiChu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacSua { get; set; }
        public string IpMaySua { get; set; }
    }
}
