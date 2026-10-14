using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LMultiReport
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportQuery { get; set; }
        public string ReportSettingFileName { get; set; }
        public string ReportSettingSearch { get; set; }
        public string ReportSettingExcel { get; set; }
        public string ReportSettingPrint { get; set; }
        public string ReportSettingOrientation { get; set; }
        public string ReportSettingColButtonPrint { get; set; }
        public short? ReportSequence { get; set; }
    }
}
