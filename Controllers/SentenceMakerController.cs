using TwoToFour.Services.SentenceMaker;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("api/[controller]")]
public class SentenceMakerController : ControllerBase
{
    private readonly ISentenceMakerService _sentenceMaker;

    public SentenceMakerController(ISentenceMakerService sentenceMaker)
    {
        _sentenceMaker = sentenceMaker;
    }
    [HttpGet]
    [Route("/YourName{name}+TimeWokeUp{time}")]
    public string SentenceMaker(string name, string time){
        return _sentenceMaker.SentenceMaker(name, time);
    }
}