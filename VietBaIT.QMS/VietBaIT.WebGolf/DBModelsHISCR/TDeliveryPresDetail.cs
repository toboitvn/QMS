using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDeliveryPresDetail
    {
        public long PresId { get; set; }
        public int DrugId { get; set; }
        public short StockId { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime NgayCapphat { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
    }
}
