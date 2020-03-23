using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaController : ControllerBase
    {
        public readonly CoronaService _coronaService;
        public CoronaController(CoronaService coronaService)
        {
            _coronaService = coronaService;
        }
        // GET: api/Corona
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_coronaService.GetTodayResult());
        }
    }
}
