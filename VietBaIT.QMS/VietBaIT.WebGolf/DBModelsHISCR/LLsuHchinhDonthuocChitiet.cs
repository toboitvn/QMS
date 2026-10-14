using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LLsuHchinhDonthuocChitiet
    {
        public long IdHchinh { get; set; }
        public int IdDonthuoc { get; set; }
        public int IdChitiet { get; set; }
        public int IdThuoc { get; set; }
        public int SluongCu { get; set; }
        public int SluongHchinh { get; set; }
    }
}
