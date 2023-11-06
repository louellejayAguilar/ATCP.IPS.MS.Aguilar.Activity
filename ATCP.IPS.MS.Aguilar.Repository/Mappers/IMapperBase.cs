using ATCP.IPS.MS.Aguilar.Model.Dto;
using ATCP.IPS.MS.Aguilar.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository.Mappers
{
    public interface IMapperBase<TEntity, TDto>
    where TEntity : class
    where TDto : class
    {
        TDto ConvertToDto(TEntity entity);
        TDto ConvertToDto(TEntity entity, TDto dto);
        CustomerDto ConvertToDto(Customers entity, CustomerDto dto);
        IList<TDto> ConvertToDtoList(IList<TEntity> entityList);
        TEntity ConvertToEntity(TDto dto);
        TEntity ConvertToEntity(TDto dto, TEntity entity);
        IList<TEntity> ConvertToEntityList(IList<TDto> dtoList);
    }
}
