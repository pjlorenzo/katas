
namespace stringcalculator.unit.test;

public class UnitTest1
{
    [Theory]
    [InlineData("",0)]
    [InlineData("1", 1)]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3,4,5,6,7,8,9,10", 55)]
    [InlineData("1\n2,3", 6)]
    [InlineData("//;\n1;2", 3)]
    public void GivenAEmptyString_ReturnZero(string numbersToAdd, int expectedResult)
    {
        var stringCalcuator = new StringCalculator();

        var result = stringCalcuator.Add(numbersToAdd);
        Assert.Equal(expectedResult, result);
        
    }
}