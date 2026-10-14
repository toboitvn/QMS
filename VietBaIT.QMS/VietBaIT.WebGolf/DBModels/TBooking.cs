using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TBooking
    {
        public int BookingId { get; set; }
        public byte BookingTypeId { get; set; }
        public DateTime BookingDateTime { get; set; }
        public short BookingGuestCount { get; set; }
        public string BookingNote { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        public byte BookingStatus { get; set; }
        public DateTime? BookingStartTime { get; set; }
        public DateTime? BookingFinishTime { get; set; }
    }
}
