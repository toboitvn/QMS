using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TGolfBagDetail
    {
        public int BagDetailId { get; set; }
        public int BagId { get; set; }
        public string ClubTypeId { get; set; }
        public string ClubBrandId { get; set; }
        public string ClubNote { get; set; }
    }
}
