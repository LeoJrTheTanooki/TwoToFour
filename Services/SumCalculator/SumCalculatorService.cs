namespace TwoToFour.Services.SumCalculator;
public class SumCalculatorService : ISumCalculatorService
{
    public int CalculateSum(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

}