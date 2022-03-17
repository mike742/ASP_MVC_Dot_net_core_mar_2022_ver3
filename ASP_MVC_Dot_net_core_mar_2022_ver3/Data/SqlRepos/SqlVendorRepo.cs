using ASP_MVC_Dot_net_core_mar_2022_ver3.Data.Interfaces;
using ASP_MVC_Dot_net_core_mar_2022_ver3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Data.SqlRepos
{
    public class SqlVendorRepo : IVendorRepo
    {
        private readonly AppDbContext _context;

        public SqlVendorRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Vendor input)
        {
            if (input == null)
            {
                throw new ArgumentException( nameof(input) );
            }

            _context.Vendors.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var vendorInDb = _context.Vendors.FirstOrDefault(v => v.V_code == id);

            if (vendorInDb != null)
            {
                _context.Vendors.Remove(vendorInDb);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetById(int id)
        {
            return _context.Vendors.ToList().Find(v => v.V_code == id);
        }

        public void Update(int id, Vendor vendor)
        {
            var vendorInDb = _context.Vendors.FirstOrDefault(v => v.V_code == id);

            if (vendorInDb != null)
            {
                vendorInDb.V_AreaCode = vendor.V_AreaCode;
                vendorInDb.V_contact = vendor.V_contact;
                vendorInDb.V_name = vendor.V_name;
                vendorInDb.V_order = vendor.V_order;
                vendorInDb.V_phone = vendor.V_phone;
                vendorInDb.V_state = vendor.V_state;

                _context.SaveChanges();
            }
        }
    }
}
