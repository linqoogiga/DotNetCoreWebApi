using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MathController : ControllerBase
    {
        private readonly IMath _math;
        public MathController(IMath math)
        {
            _math = math;
        }

        [HttpGet("{add}")]
        public int Add(int a, int b)
        {
            int c = _math.Add(a,b);
            return c;
        }

    }
}
