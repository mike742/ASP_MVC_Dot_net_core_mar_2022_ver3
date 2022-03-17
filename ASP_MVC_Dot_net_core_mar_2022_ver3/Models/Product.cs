using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Code")]
        public string P_Code { get; set; }
        [Display(Name = "Description")]
        public string P_descript { get; set; }
        [Display(Name = "Date")]
        public DateTime P_InDate { get; set; }
        [Display(Name = "QOH")]
        public int P_QOH { get; set; }
        [Display(Name = "Min")]
        public int P_Min { get; set; }
        [Display(Name = "Price, $")]
        public double P_Price { get; set; }
        [Display(Name = "Discount")]
        public double P_Discount { get; set; }
        
        [ForeignKey("Vendor")]
        [Display(Name = "Vendor Code")]
        public int? V_code { get; set; }
        public Vendor Vendor { get; set; }
    }
}
