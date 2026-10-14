using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LGeneralList
    {
        public int ListId { get; set; }
        public string ListType { get; set; }
        public string ListCode { get; set; }
        public string ListValue { get; set; }
        public string ListName { get; set; }
        public short? ListSequence { get; set; }
    }
}
