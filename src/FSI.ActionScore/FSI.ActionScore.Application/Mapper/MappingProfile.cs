using AutoMapper;
using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FSI.ActionScore.Application.Mapper
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ImpactType, ImpactTypeDto>().ReverseMap();
            CreateMap<UserAccount, UserAccountDto>().ReverseMap();
            CreateMap<ActionModel, ActionModelDto>().ReverseMap();
            CreateMap<ActionRecord, ActionRecordDto>().ReverseMap();
        }
    }
}
