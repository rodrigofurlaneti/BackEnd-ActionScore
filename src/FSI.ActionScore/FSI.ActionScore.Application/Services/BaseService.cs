using AutoMapper;
using FSI.ActionScore.Application.Interfaces;
using FSI.ActionScore.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSI.ActionScore.Application.Services
{
    public class BaseService<TDto, TEntity> : IBaseService<TDto>
        where TDto : class
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity is null ? null : _mapper.Map<TDto>(entity);
        }

        public async Task<int> InsertAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            return await _repository.InsertAsync(entity);
        }

        public async Task<bool> UpdateAsync(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            // garantimos que a PK do dto é o id
            var idProperty = typeof(TEntity).GetProperty("Id");
            idProperty?.SetValue(entity, id);

            return await _repository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
