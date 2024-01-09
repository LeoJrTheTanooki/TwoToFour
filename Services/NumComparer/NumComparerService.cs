namespace TwoToFour.Services.NumComparer;
public class NumComparerService : INumComparerService
{
    public string CompareNums(int numOne, int numTwo)
    {
        if (numOne < numTwo)
        {
            return $"{numOne} < {numTwo}";
        }
        else
        {
            return $"{numOne} > {numTwo}";
        }
    }
}