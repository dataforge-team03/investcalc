using InvestCalc.Models;
using InvestCalc.Services;
using Microsoft.AspNetCore.Mvc;

namespace InvestCalc.Api
{
    [ApiController]
    [Route("calc")]
    public class CalcController : ControllerBase
    {
        private readonly LocalCalcService _local;

        public CalcController(LocalCalcService local)
        {
            _local = local;
        }

        [HttpPost("local")]
        public IActionResult Local([FromBody] CalcRequest req)
        {
            var result = _local.Calculate(req);
            return Ok(result);
        }
    }
}
