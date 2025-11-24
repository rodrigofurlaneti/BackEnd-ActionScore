
namespace FSI.ActionScore.Application.Interfaces
{
    public interface IBaseService<TDto>
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(int id);
        Task<int> InsertAsync(TDto dto);
        Task<bool> UpdateAsync(int id, TDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
