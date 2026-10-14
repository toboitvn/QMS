using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LStocks
    {
        public short StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public byte StockNature { get; set; }
        public byte StockType { get; set; }
        public short DepartmentId { get; set; }
        public string SDesc { get; set; }
        public byte? StockCategory { get; set; }
        public int? IntOrder { get; set; }
    }
}
