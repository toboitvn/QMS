using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TLichSuTrukho
    {
        public int Id { get; set; }
        public int PresId { get; set; }
        public int StockId { get; set; }
        public int DrugId { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityStock { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
