using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LQuickSearch
    {
        public long Id { get; set; }
        public string Loai { get; set; }
        public string Shortform { get; set; }
        public string Fullform { get; set; }
        public string CompareVal { get; set; }
    }
}
