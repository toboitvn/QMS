using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LSotayVietTat
    {
        public int Id { get; set; }
        public string TenVietTat { get; set; }
        public string TenViet { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string KeyCode { get; set; }
        public string IcdChinh { get; set; }
        public string IcdPhu { get; set; }
    }
}
