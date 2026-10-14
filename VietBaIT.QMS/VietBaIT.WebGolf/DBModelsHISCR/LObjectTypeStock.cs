using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LObjectTypeStock
    {
        public string ObjectTypeCode { get; set; }
        public int StockId { get; set; }
        public int? ThuTu { get; set; }
    }
}
