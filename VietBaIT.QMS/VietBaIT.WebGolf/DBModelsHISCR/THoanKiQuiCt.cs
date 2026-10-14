using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class THoanKiQuiCt
    {
        public int Id { get; set; }
        public int IdHoanKiQui { get; set; }
        public int IdKiQui { get; set; }
        public string DepositCode { get; set; }
        public decimal SoTien { get; set; }
    }
}
