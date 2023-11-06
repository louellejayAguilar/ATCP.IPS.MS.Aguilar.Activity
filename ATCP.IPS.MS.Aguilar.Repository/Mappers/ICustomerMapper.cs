using ATCP.IPS.MS.Aguilar.Model.Dto;
using ATCP.IPS.MS.Aguilar.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository.Mappers
{
    public interface ICustomerMapper : IMapperBase<Customers, CustomerDto>
    {
        CustomerDto ConvertToDto(Customers entity, CustomerDto dto);
        Customers ConvertToEntity(CustomerDto dto, Customers entity);
    }

}
