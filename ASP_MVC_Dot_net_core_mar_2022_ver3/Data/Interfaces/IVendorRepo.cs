using ASP_MVC_Dot_net_core_mar_2022_ver3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Data.Interfaces
{
    public interface IVendorRepo
    {
        public IEnumerable<Vendor> GetAll();
        public void Create(Vendor input);
        public Vendor GetById(int id);
        public void Update(int id, Vendor vendor);
        public void Delete(int id);
    }
}
