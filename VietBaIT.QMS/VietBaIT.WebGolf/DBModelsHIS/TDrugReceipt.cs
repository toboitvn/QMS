using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDrugReceipt
    {
        public int ReceiptId { get; set; }
        public short? FromStockId { get; set; }
        public short ToStockId { get; set; }
        public DateTime InputDate { get; set; }
        public short InputUser { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public short? HasUpdatedPrice { get; set; }
        public short? SupplyUnitId { get; set; }
        public string Lot { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? NgayXacnhan { get; set; }
        public DateTime? NgayChot { get; set; }
    }
}
