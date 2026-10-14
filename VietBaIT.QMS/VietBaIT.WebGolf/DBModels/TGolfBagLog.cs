using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TGolfBagLog
    {
        public int BagLogId { get; set; }
        public int BagId { get; set; }
        public byte BagLogTypeId { get; set; }
        public DateTime BagLogTime { get; set; }
        public string BagLogNote { get; set; }
        public int CreateBy { get; set; }
    }
}
