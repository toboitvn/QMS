using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LRoomBedObjectType
    {
        public int Id { get; set; }
        public int RomId { get; set; }
        public int BedId { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Surcharge { get; set; }
        public string SDesc { get; set; }
        public string ObjectTypeCode { get; set; }
        public int? ObjectTypeType { get; set; }
        public int? IsPayment { get; set; }
        public string KieuThue { get; set; }
        public decimal? GiaCu { get; set; }
    }
}
