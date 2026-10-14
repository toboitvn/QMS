using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TExamDetail
    {
        public long ExamId { get; set; }
        public string Circulation { get; set; }
        public string Respiration { get; set; }
        public string Digestion { get; set; }
        public string KidneyInfo { get; set; }
        public string NerveInfo { get; set; }
        public string MuscleInfo { get; set; }
        public string DentalInfo { get; set; }
        public string EyeInfo { get; set; }
        public string Endocrine { get; set; }
        public string Nutrition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
