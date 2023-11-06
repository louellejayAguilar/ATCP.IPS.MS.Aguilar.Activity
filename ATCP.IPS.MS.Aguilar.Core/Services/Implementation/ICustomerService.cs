using ATCP.IPS.MS.Aguilar.Model.Dto;
using System.Collections.Generic;

namespace ATCP.IPS.MS.Aguilar.Core.Services.Implementation
{
    public interface ICustomerService
    {
        CustomerDto GetDtoById(int id);
        IList<CustomerDto> GetDto();
        void Insert(CustomerDto dto);
        void Delete(CustomerDto dto);
        void Delete(int id);
        void Update(CustomerDto dto);
        void Save();
    }
}
