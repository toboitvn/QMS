using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDeliverDrugDetail
    {
        public long DetailId { get; set; }
        public long Id { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
        public byte HasDelivered { get; set; }
        public short StockId { get; set; }
    }
}
