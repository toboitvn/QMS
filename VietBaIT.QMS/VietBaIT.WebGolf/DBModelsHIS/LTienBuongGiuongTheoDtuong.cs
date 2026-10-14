using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LTienBuongGiuongTheoDtuong
    {
        public int Id { get; set; }
        public string ObjectTypeCode { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public string Dkien { get; set; }
    }
}
