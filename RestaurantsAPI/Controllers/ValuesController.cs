using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace RestaurantsAPI.Controllers
{
    
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        [HttpGet("getstring")]
        public IActionResult getString()
        {
            return Ok("Valid req");
        }
    }
}
