namespace FactorialLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = FactorialService.Factorial(0);
        Assert.Equal(1, result);
    }
}