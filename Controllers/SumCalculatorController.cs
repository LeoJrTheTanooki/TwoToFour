using TwoToFour.Services.SumCalculator;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("api/[controller]")]
public class SumCalculatorController : ControllerBase
{
    private readonly ISumCalculatorService _sumCalculator;

    public SumCalculatorController(ISumCalculatorService sumCalculator)
    {
        _sumCalculator = sumCalculator;
    }
    [HttpGet]
    [Route("GetSum{numOne}+{numTwo}")]
    public int CalculateSum(int numOne, int numTwo)
    {
        return _sumCalculator.CalculateSum(numOne, numTwo);
    }
}