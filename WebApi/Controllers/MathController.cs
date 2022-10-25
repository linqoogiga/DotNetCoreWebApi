using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MathController : ControllerBase
    {
        [HttpGet("{add}")]
        public int Add(int a, int b)
        {
            int c = a + b+1;
            return c;
        }

    }
}
