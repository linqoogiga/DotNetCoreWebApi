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

        [HttpGet("{Count}")]
        public int Count(int act,int a, int b)
        {
            int c = 0;
            //===
            if (act == 1)
            {
                c = _math.Add(a, b);
            }
            else if (act == 2)
            {
                c = _math.Minus(a, b);
            }
            else if (act == 3)
            {
                c = _math.Multiple(a, b);
            }
            else if (act == 4)
            {
                c = _math.divide(a, b);
            }
            //===
            return c;
        }

    }
}
