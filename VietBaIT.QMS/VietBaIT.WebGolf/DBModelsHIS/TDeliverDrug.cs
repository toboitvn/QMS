using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDeliverDrug
    {
        public long Id { get; set; }
        public DateTime InputDate { get; set; }
        public short InputUserId { get; set; }
        public short DeliverUserId { get; set; }
        public int? PresId { get; set; }
        public string SDesc { get; set; }
    }
}
