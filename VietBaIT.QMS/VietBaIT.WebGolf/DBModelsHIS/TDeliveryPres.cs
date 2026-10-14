using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDeliveryPres
    {
        public int DeliveryId { get; set; }
        public int PresId { get; set; }
        public string PatientCode { get; set; }
    }
}
