using AutoMapper;
using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Application.Interfaces;
using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;

namespace FSI.ActionScore.Application.Services
{
    public sealed class ActionRecordService
        : BaseService<ActionRecordDto, ActionRecord>, IActionRecordService
    {
        public ActionRecordService(IActionRecordRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
