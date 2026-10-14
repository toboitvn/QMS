using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewChiphiNgoaiTruBackup
    {
        public int? PaymentTypeId { get; set; }
        public long MainId { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? PaymentStatus { get; set; }
        public long AxuId { get; set; }
        public string PatientCode { get; set; }
        public long? PatientId { get; set; }
        public string ServiceDetailName { get; set; }
        public string TenBhyt { get; set; }
        public double? Quantity { get; set; }
        public byte? IsPayment { get; set; }
        public int IsCancel { get; set; }
        public short? DepartmentId { get; set; }
        public short DoctorAssignId { get; set; }
        public int? BhytStatus { get; set; }
        public int? ThuTuIn { get; set; }
        public string UnitName { get; set; }
        public int? XacNhan { get; set; }
        public int TrongGoi { get; set; }
        public int DaGuiCls { get; set; }
        public string NguoiGuiCls { get; set; }
        public string NgayGuiCls { get; set; }
        public string NgayDangky { get; set; }
        public int Noitru { get; set; }
        public decimal? MienGiam { get; set; }
        public int? PaymentId { get; set; }
        public int? IdGoiDvu { get; set; }
        public long IdThe { get; set; }
        public decimal TyleTt { get; set; }
    }
}
