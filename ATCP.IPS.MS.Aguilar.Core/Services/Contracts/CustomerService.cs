using ATCP.IPS.MS.Aguilar.Core.Services.Implementation;
using ATCP.IPS.MS.Aguilar.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Core.Services.Contracts
{
    public class CustomerService : ICustomerService
    {
        public void Delete(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> GetDto()
        {
            var customer = new
            {
                CustomerID = 1,
                firstName = "Kayla",
                middleName = "McClain",
                lastName = "Ward",
                Address = "3217 Saints AlleyTampa, FL, 33614",
                Age = 21,
                Gender = "Female"
            };
            var customerDto = new CustomerDto
            {
                CustomerID = customer.CustomerID,
                firstName = customer.firstName,
                middleName = customer.middleName,
                lastName = customer.lastName,  
                Address = customer.Address,
                Age = customer.Age,
                Gender = customer.Gender
            };

            var customerDtoList = new List<CustomerDto>
            {
                customerDto
            };
            return customerDtoList;
        }
        public CustomerDto GetDtoById(int id)
        {
            var customerDto = new CustomerDto();
            customerDto = GetDto().Where(c => c.CustomerID == id).FirstOrDefault();
            if (customerDto == null)
                return new CustomerDto();
            return customerDto;
        }
        public void Insert(CustomerDto dto)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            throw new NotImplementedException();
        }
        public void Update(CustomerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
