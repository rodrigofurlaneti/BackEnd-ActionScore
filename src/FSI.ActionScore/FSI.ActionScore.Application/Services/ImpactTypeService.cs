using AutoMapper;
using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Application.DTOs;
using FSI.ActionScore.Application.Interfaces;
using FSI.ActionScore.Domain.Entities;
using FSI.ActionScore.Domain.Interfaces;

namespace FSI.ActionScore.Application.Services
{
    public sealed class ImpactTypeService
        : BaseService<ImpactTypeDto, ImpactType>, IImpactTypeService
    {
        public ImpactTypeService(IImpactTypeRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
