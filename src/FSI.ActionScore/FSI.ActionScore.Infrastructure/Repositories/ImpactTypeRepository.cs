using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;

namespace FSI.ActionScore.Infrastructure.Repositories
{
    public sealed class ImpactTypeRepository
    : BaseRepository<ImpactType>, IImpactTypeRepository
    {
        public ImpactTypeRepository(ActionScoreDbContext context) : base(context) { }
    }
}