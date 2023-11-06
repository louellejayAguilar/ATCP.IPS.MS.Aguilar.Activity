using ATCP.IPS.MS.Aguilar.Model.Dto;
using ATCP.IPS.MS.Aguilar.Model.Entity;
using ATCP.IPS.MS.Aguilar.Repository.Contract;
using ATCP.IPS.MS.Aguilar.Repository.Mappers;
using ATCP.IPS.MS.Aguilar.Repository;
using ATCP.IPS.MS.Aguilar.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Core.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _repository;
        private readonly IMapperBase<Customers, CustomerDto> _mapper;
        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository repository, ICustomerMapper
       mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }
        public void Delete(CustomerDto dto)
        {
            _repository.Delete(_mapper.ConvertToEntity(dto));
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public virtual IList<CustomerDto> GetDtoList(Expression<Func<Customers, bool>> filter = null,
        Func<IQueryable<Customers>, IOrderedQueryable<Customers>> orderBy = null,
        string includeProperties = "")
        {
            return _mapper.ConvertToDtoList(_repository.Get(filter, orderBy, includeProperties).ToList());
        }
        public IList<CustomerDto> GetDto()
        {
            return GetDtoList(null, null, "");
        }
        public virtual Customers GetById(int id)
        {
            return _repository.GetById(id);
        }
        public CustomerDto GetDtoById(int id)
        {
            return _mapper.ConvertToDto(GetById(id));

        }
        public void Insert(CustomerDto dto)
        {
            _repository.Insert(_mapper.ConvertToEntity(dto));
        }
        public void Save()
        {
            _unitOfWork.Save();
        }
        public void Update(CustomerDto dto)
        {
            _repository.Update(_mapper.ConvertToEntity(dto));

        }
    }

}
