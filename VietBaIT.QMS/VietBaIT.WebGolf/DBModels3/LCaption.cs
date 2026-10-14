using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels3
{
    public partial class LCaption
    {
        public int IdCaption { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool TrangThai { get; set; }
    }
}
