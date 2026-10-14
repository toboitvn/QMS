using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LHuongDanSuDung
    {
        public int HdsdId { get; set; }
        public string HdsdFormName { get; set; }
        public string HdsdFormDesc { get; set; }
        public short HdsdFormWidth { get; set; }
        public short HdsdFormHeight { get; set; }
        public string HdsdDetail { get; set; }
    }
}
