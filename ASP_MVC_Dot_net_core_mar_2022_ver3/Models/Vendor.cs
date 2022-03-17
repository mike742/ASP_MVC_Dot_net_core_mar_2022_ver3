using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Models
{
    public class Vendor
    {
        [Key]
        [Display(Name = "Code")]
        public int V_code { get; set; }
        [Display(Name = "Name")]
        public string V_name { get; set; }
        [Display(Name = "Contact")]
        public string V_contact { get; set; }
        [Display(Name = "Area Code")]
        public int V_AreaCode { get; set; }
        [Display(Name = "Phone")]
        public string V_phone { get; set; }
        [Display(Name = "State")]
        public string V_state { get; set; }
        [Display(Name = "Order")]
        public string V_order { get; set; }
    }
}
