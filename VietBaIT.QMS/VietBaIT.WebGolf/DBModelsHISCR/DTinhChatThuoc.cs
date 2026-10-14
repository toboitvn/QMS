using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DTinhChatThuoc
    {
        public short IdTinhChat { get; set; }
        public string MaTinhChat { get; set; }
        public string TenTinhChat { get; set; }
        public short? ThuTu { get; set; }
        public string KieuThuocvt { get; set; }
        public bool? InTach { get; set; }
        public string ReportCode { get; set; }
    }
}
