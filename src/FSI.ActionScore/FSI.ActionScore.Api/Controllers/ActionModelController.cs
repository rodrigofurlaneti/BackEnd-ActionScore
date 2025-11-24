using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FSI.ActionScore.Api.Controllers
{
    [Route("api/[controller]")]
    public sealed class ActionModelsController
        : BaseController<ActionModelDto, IActionModelService>
    {
        public ActionModelsController(IActionModelService service) : base(service)
        {
        }
    }
}
