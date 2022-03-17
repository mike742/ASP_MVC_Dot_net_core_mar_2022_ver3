using System;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
