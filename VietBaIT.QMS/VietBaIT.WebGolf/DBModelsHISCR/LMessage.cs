using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LMessage
    {
        public string MessageId { get; set; }
        public string MessageType { get; set; }
        public string MessageName { get; set; }
        public int? MessageOrder { get; set; }
    }
}
