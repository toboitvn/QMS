using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LTinhHinhRaVien
    {
        public short IdThinhRvien { get; set; }
        public string TenThinhRvien { get; set; }
        public short? Stt { get; set; }
        public byte? ChiDoc { get; set; }
    }
}
