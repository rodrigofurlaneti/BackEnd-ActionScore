using FSI.ActionScore.Application.Dtos;
using FSI.ActionScore.Application.DTOs;
using FSI.ActionScore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FSI.ActionScore.Api.Controllers
{
    [Route("api/[controller]")]
    public sealed class UserAccountsController
        : BaseController<UserAccountDto, IUserAccountService>
    {
        public UserAccountsController(IUserAccountService service) : base(service)
        {
        }
    }
}
