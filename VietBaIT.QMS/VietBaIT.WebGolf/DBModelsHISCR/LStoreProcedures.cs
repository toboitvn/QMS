using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LStoreProcedures
    {
        public short ProcId { get; set; }
        public string ProcName { get; set; }
        public string ProcPrefix { get; set; }
        public string ProcPostfix { get; set; }
        public short? ProcSequence { get; set; }
    }
}
