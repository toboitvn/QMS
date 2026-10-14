using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TGolfBag
    {
        public int BagId { get; set; }
        public string BagTag { get; set; }
        public string BagImagePath { get; set; }
        public byte ClubCount { get; set; }
        public int MemberId { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public byte BagStatus { get; set; }
    }
}
