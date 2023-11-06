using Microsoft.Extensions.Logging;
using ATCP.IPS.MS.Aguilar.Core.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using ATCP.IPS.MS.Aguilar.Core.Services.Implementation;
using ATCP.IPS.MS.Aguilar.Core.Services.Contracts;

namespace ATCP.IPS.MS.Aguilar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController<CustomerController>
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("{customerID}")]
        public string GetFullNameById(int customerID)
        {
            var customer = _customerService.GetDtoById(customerID);

            Logger.Log(LogLevel.Information, "Customer Index");
            return StringUtility.Concatenate(customer.firstName, customer.lastName, string.Empty);
        }

        [HttpGet("{lastName}/{firstName}")]
        public string GetFullName(string firstName, string lastName)
        {
            throw new Exception("Application Error");
            Logger.Log(LogLevel.Information, "Customer Index");
            string name = StringUtility.Concatenate(firstName, lastName, string.Empty);
            return name;
        }

        [HttpGet("{lastName}/{firstName}/{delimiter}")]
        public string GetFullNameWithComma(string firstName, string lastName, string delimiter)
        {
            string name = StringUtility.Concatenate(firstName, lastName, delimiter);
            return name;
        }
    }
}
