using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;

namespace FSI.ActionScore.Infrastructure.Repositories
{
    public sealed class ActionModelRepository
    : BaseRepository<ActionModel>, IActionModelRepository
    {
        public ActionModelRepository(ActionScoreDbContext context) : base(context) { }
    }
}
