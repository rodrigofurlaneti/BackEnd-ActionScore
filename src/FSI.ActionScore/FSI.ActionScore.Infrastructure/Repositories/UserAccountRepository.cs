using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;
using FSI.ActionScore.Infrastructure.Persistence;

namespace FSI.ActionScore.Infrastructure.Repositories
{
    public sealed class UserAccountRepository
: BaseRepository<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(ActionScoreDbContext context) : base(context) { }
    }
}
