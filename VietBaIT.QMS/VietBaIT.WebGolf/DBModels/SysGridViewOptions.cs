using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysGridViewOptions
    {
        public string Branchid { get; set; }
        public string Uid { get; set; }
        public string Container { get; set; }
        public string Subsystem { get; set; }
        public string Datagridview { get; set; }
        public string Colname { get; set; }
        public string OriginalWidth { get; set; }
        public short Alignment { get; set; }
        public short Codan { get; set; }
    }
}
