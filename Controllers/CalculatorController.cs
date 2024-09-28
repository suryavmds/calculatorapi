using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Add method: accepts two decimal parameters and returns their sum
        [HttpGet("add")]
        public ActionResult<decimal> Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a + b);
        }

        // Subtract method: accepts two decimal parameters and returns their difference
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a - b);
        }

        // Multiply method: accepts two decimal parameters and returns their product
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a * b);
        }

        // Divide method: accepts two decimal parameters and returns their quotient
        [HttpGet("divide")]
        public ActionResult<decimal> Divide([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return Ok(a / b);
        }

        // Modulo method: accepts two decimal parameters and returns the remainder
        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return Ok(a % b);
        }
    }
}