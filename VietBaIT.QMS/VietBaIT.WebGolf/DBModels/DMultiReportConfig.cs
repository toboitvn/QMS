using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class DMultiReportConfig
    {
        public int MultiReportConfigId { get; set; }
        public short MultiReportId { get; set; }
        public byte MultiReportConfigTableIndex { get; set; }
        public string MultiReportConfigSqlColName { get; set; }
        public string MultiReportConfigExcelColName { get; set; }
        public byte? MultiReportConfigExcelColWidth { get; set; }
        public byte? MultiReportConfigExcelColPosition { get; set; }
        public string MultiReportConfigExcelColNumberFormat { get; set; }
        public string MultiReportConfigExcelColAggregateFunction { get; set; }
    }
}
