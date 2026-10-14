using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LServiceListV2
    {
        public string ServiceId { get; set; }
        public string VnServiceName { get; set; }
        public string EnServiceName { get; set; }
        public short ServiceTypeId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public int? NmrFromTime { get; set; }
        public int? NmrToTime { get; set; }
        public short MuId { get; set; }
        public decimal Price { get; set; }
        public short Status { get; set; }
        public string Desc { get; set; }
        public short? DiscountType { get; set; }
        public decimal? DiscountRate { get; set; }
        public short? Announce { get; set; }
        public int? ServiceSequence { get; set; }
    }
}
