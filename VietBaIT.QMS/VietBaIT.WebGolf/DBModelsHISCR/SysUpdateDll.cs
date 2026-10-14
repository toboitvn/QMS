using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysUpdateDll
    {
        public int SysUpdate { get; set; }
        public string ServerName { get; set; }
        public string FtpName { get; set; }
        public string TenFile { get; set; }
        public string TenMaytinh { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayUpdate { get; set; }
        public string DiaChiIp { get; set; }
        public string GhiChu { get; set; }
        public string DiaChiMac { get; set; }
        public string MaKhoaThien { get; set; }
        public string MaCoSo { get; set; }
        public string GuidKey { get; set; }
    }
}
