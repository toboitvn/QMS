using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class SysTrinhky
    {
        public string ReportName { get; set; }
        public string ObjectName { get; set; }
        public string FontName { get; set; }
        public int? FontSize { get; set; }
        public string FontStype { get; set; }
        public string ObjectContent { get; set; }
        public string TitleReport { get; set; }
    }
}
