using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class TPaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentTime { get; set; }
        public int InvoiceId { get; set; }
        public byte PaymentMethodId { get; set; }
        public string PaymentTransactionId { get; set; }
    }
}
