using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class DMultiReport
    {
        public short MultiReportId { get; set; }
        public string MultiReportName { get; set; }
        public string MultiReportType { get; set; }
        public string MultiReportQueryType { get; set; }
        public string MultiReportQueryString { get; set; }
        public short? MultiReportSequence { get; set; }
        public byte? MultiReportIsAdmin { get; set; }
    }
}
