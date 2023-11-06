using ATCP.IPS.MS.Aguilar.Model.Entity;
using ATCP.IPS.MS.Aguilar.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository.Contract
{
    public class CustomerRepository : Repository<Customers>, ICustomerRepository
    {
        public CustomerRepository(IAppDbContext context) : base(context)
        {
        }
    }   
}
