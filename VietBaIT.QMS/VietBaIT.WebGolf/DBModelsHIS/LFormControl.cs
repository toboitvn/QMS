using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LFormControl
    {
        public int ControlId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlTypeName { get; set; }
        public string PropertyName { get; set; }
        public string Value { get; set; }
    }
}
