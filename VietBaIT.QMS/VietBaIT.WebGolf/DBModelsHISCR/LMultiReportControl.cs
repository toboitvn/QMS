using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LMultiReportControl
    {
        public int ReportControlId { get; set; }
        public int ReportId { get; set; }
        public string ControlType { get; set; }
        public string ControlName { get; set; }
        public string ControlText { get; set; }
        public short ControlLocationX { get; set; }
        public short ControlLocationY { get; set; }
        public string ControlSetting { get; set; }
        public string ReportControlDefaultValue { get; set; }
        public byte? ReportControlSequence { get; set; }
    }
}
