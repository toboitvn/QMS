using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TExamOther
    {
        public long ExamId { get; set; }
        public byte? Allergy { get; set; }
        public short? AllericDay { get; set; }
        public byte? DrugInfo { get; set; }
        public short? DrugDay { get; set; }
        public byte? WineInfo { get; set; }
        public short? WineDay { get; set; }
        public byte? TobaccoInfo { get; set; }
        public short? TobaccoDay { get; set; }
        public byte? PipeInfo { get; set; }
        public short? PipeTobaDay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
