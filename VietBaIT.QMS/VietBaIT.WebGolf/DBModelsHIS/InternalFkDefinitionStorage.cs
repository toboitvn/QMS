using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class InternalFkDefinitionStorage
    {
        public int Id { get; set; }
        public string FkName { get; set; }
        public string FkCreationStatement { get; set; }
        public string FkDestructionStatement { get; set; }
        public string TableTruncationStatement { get; set; }
    }
}
