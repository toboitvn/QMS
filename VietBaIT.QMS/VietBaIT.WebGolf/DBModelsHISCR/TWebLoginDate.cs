using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TWebLoginDate
    {
        public int IdUserLogin { get; set; }
        public int IdBenhnhan { get; set; }
        public DateTime? LoginDate { get; set; }
        public string SoDienThoai { get; set; }
    }
}
