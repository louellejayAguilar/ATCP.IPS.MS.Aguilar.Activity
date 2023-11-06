using ATCP.IPS.MS.Aguilar.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository.Contract
{
    public interface ICustomerAdoNetRepository
    {
        Customers GetById(int id);
        IList<Customers> Get();
        void Insert(Customers entity);
        void Delete(int id);
        void Update(Customers entity);
    }
}
