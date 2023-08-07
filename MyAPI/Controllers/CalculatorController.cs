using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        // GET: api/<CalculatorController>


        // GET api/<CalculatorController>/5
        [HttpGet("Add")]
        public int Get(int a, int b)
        {
            return _calculatorService.Add(a, b);
        }

        [HttpGet("Subtract")]
        public int Subtract(int a, int b)
        {
            return _calculatorService.Subtract(a, b);
        }

        [HttpGet("Multiply")]
        public int Multiply(int a, int b)
        {
            return _calculatorService.Multiply(a, b);
        }

        [HttpGet("Divide")]
        public int Divide(int a, int b)
        {
            return _calculatorService.Divide(a, b);
        }
    }
}
