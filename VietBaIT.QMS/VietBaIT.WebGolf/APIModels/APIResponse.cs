using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.APIHelpers
{
    public class APIResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object data { get; set; }

        public APIResponse(bool success, string message, object data)
        {
            this.success = success;
            this.message = message;
            this.data = data;
        }
    }
}