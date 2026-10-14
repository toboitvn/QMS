using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LSurveys
    {
        public short SurveyId { get; set; }
        public string SurveyCode { get; set; }
        public string SurveyName { get; set; }
        public string ParentCode { get; set; }
        public short? IntOrder { get; set; }
        public byte? SurveyType { get; set; }
        public string SDesc { get; set; }
    }
}
