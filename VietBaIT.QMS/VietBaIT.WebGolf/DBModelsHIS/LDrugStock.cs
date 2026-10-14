using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDrugStock
    {
        public short StockId { get; set; }
        public int DrugId { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ManuDate { get; set; }
        public int Quantity { get; set; }
        public decimal OriginalPrice { get; set; }
        public DateTime? InputDate { get; set; }
        public byte? StockCategory { get; set; }
        public string Lot { get; set; }
        public short? SupplyUnitId { get; set; }
        public decimal? GiaBan { get; set; }
    }
}
