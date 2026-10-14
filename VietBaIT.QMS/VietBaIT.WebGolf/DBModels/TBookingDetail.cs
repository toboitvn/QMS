using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TBookingDetail
    {
        public int BookingDetailId { get; set; }
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNote { get; set; }
        public int? MemberId { get; set; }
        public string CustomerBagTag { get; set; }
    }
}
