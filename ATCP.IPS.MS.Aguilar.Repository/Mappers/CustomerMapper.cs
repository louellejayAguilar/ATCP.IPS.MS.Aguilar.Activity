using ATCP.IPS.MS.Aguilar.Model.Dto;
using ATCP.IPS.MS.Aguilar.Model.Entity;

namespace ATCP.IPS.MS.Aguilar.Repository.Mappers
{
    public class CustomerMapper : MapperBase<Customers, CustomerDto>, ICustomerMapper
    {
        public override CustomerDto ConvertToDto(Customers entity, CustomerDto dto)
        {
            var mappedModel = dto ?? new CustomerDto();
            if (entity == null)
            {
                return mappedModel;
            }
            mappedModel.CustomerID = entity.CustomerId;
            mappedModel.firstName = entity.FirstName;
            mappedModel.middleName = entity.MiddleName;
            mappedModel.lastName = entity.LastName;
            mappedModel.Address = entity.Address;
            mappedModel.Age = entity.Age;
            mappedModel.Gender = entity.Gender;
            mappedModel.CreatedBy = entity.CreatedBy;
            mappedModel.CreatedDttm = entity.CreatedDttm;
            mappedModel.UpdatedBy = entity.UpdatedBy;
            mappedModel.UpdatedDttm = entity.UpdatedDttm;
            return mappedModel;
        }

        public CustomerDto ConvertToDto(Customers entity)
        {
            throw new NotImplementedException();
        }

        public CustomerDto ConvertToDto(Customers entity, CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> ConvertToDtoList(IList<Customers> entityList)
        {
            throw new NotImplementedException();
        }

        public override Customers ConvertToEntity(CustomerDto dto, Customers entity)
        {
            var mappedModel = entity ?? new Customers();
            if (dto == null)
            {
                return mappedModel;
            }
            mappedModel.CustomerId = dto.CustomerID;
            mappedModel.FirstName = dto.firstName;
            mappedModel.MiddleName = dto.middleName;
            mappedModel.LastName = dto.lastName;
            mappedModel.Address = dto.Address;
            mappedModel.Age = dto.Age;
            mappedModel.Gender = dto.Gender;
            mappedModel.CreatedBy = dto.CreatedBy;
            mappedModel.CreatedDttm = dto.CreatedDttm;
            mappedModel.UpdatedBy = dto.UpdatedBy;
            mappedModel.UpdatedDttm = dto.UpdatedDttm;
            return mappedModel;
        }

        public Customers ConvertToEntity(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public Customers ConvertToEntity(CustomerDto dto, Customers entity)
        {
            throw new NotImplementedException();
        }

        public IList<Customers> ConvertToEntityList(IList<CustomerDto> dtoList)
        {
            throw new NotImplementedException();
        }
    }
}
