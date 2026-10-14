using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ExportExcelStruct
    {
        public int StructId { get; set; }
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public string CellTieude { get; set; }
        public string CellCondition { get; set; }
        public string ColBegin { get; set; }
        public int RowBegin { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
