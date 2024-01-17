
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using SharedServices.Interfaces;
using WebApp.Attributes;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAmountController : Controller
    {
        private IUserAmountService _service;
        private IMapper _mapper;
        public UserAmountController(IUserAmountService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getAmountForUser")]
        [Authorize]
        [PermissionAtribute((int)PermissionTypes.RoleAdmin)]
        public async Task<ActionResult<double>> GetAmountForUser(long id)
        {
            var result = await _service.GetAmountForUser(id);
            return Ok(result);
        }

    }
}
