using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FSI.ActionScore.Api.Controllers
{
    [Route("api/[controller]")]
    public sealed class ActionRecordsController
        : BaseController<ActionRecordDto, IActionRecordService>
    {
        public ActionRecordsController(IActionRecordService service) : base(service)
        {
        }
    }
}
