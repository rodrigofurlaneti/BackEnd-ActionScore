using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;

namespace FSI.ActionScore.Infrastructure.Repositories
{
    public sealed class ActionRecordRepository
    : BaseRepository<ActionRecord>, IActionRecordRepository
    {
        public ActionRecordRepository(ActionScoreDbContext context) : base(context) { }
    }
}
