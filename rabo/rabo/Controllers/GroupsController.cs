using Microsoft.AspNetCore.Mvc;
using rabo.Services;

namespace rabo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly IScheduleService _service;

        public GroupsController(IScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGroups()
        {
            var groups = await _service.GetAllGroups();
            return Ok(groups);
        }
    }
}