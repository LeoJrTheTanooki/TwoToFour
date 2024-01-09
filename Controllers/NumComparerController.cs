using TwoToFour.Services.NumComparer;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("api/[controller]")]
public class NumComparerController : ControllerBase
{
    private readonly INumComparerService _numComparer;

    public NumComparerController(INumComparerService numComparer)
    {
        _numComparer = numComparer;
    }
    [HttpGet]
    [Route("CompareNums{numOne}+{numTwo}")]
    public string CompareNums(int numOne, int numTwo)
    {
        return _numComparer.CompareNums(numOne, numTwo);
    }
}
