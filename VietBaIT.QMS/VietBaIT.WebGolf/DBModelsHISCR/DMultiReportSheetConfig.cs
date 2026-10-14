using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DMultiReportSheetConfig
    {
        public int MultiReportSheetConfigId { get; set; }
        public short MultiReportId { get; set; }
        public short MultiReportConfigTableIndex { get; set; }
        public byte HeaderBlankRowCount { get; set; }
        public string HeaderTitle { get; set; }
        public short HeaderTitleCellCount { get; set; }
        public string SheetName { get; set; }
        public byte SheetSequence { get; set; }
    }
}
