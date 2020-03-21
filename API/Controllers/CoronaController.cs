using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using Microsoft.AspNetCore.Http;
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
