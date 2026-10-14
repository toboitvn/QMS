using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ExportExcelStructDetail
    {
        public int StructdetailId { get; set; }
        public int StructId { get; set; }
        public string SqlColumn { get; set; }
        public string SqlColumnDescription { get; set; }
        public string SqlDatatype { get; set; }
        public string ExcelColumn { get; set; }
        public bool IsFormular { get; set; }
        public bool? IsGroup { get; set; }
        public int? GroupOrder { get; set; }
        public string GroupFormularForTotal { get; set; }
        public int? GroupColor { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
