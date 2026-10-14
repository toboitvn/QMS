using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDrugType
    {
        public short DrugTypeId { get; set; }
        public string DrugTypeCode { get; set; }
        public string DrugTypeName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public string MaNhomThuoc { get; set; }
        public short? InRieng { get; set; }
        public string TenBhyt { get; set; }
        public int? ParentId { get; set; }
        public int? CoChiTiet { get; set; }
    }
}
