using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LGiuongLoaiBg
    {
        public short IdLoaiBg { get; set; }
        public short BedId { get; set; }

        public virtual LBeds Bed { get; set; }
        public virtual LLoaiBg IdLoaiBgNavigation { get; set; }
    }
}
