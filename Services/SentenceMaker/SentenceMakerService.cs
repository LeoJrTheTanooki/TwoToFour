namespace TwoToFour.Services.SentenceMaker;

public class SentenceMakerService : ISentenceMakerService
{
    public string SentenceMaker(string name, string time)
    {
        return $"Oh hey {name}, in case you're wondering, you woke up at {time}.";
    }
}
