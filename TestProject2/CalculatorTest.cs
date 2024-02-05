namespace TestProject2;
using ConsoleApp1;
[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void CanFindFactorial()
    {
        var calculator = new Calculator();

        Assert.AreEqual(5040,calculator.Factorial(7));
        Assert.AreEqual(1,calculator.Factorial(0));
    }
    
    [TestMethod]
    public void CanNotFindNegativeFactorial()
    {
        var calculator = new Calculator();

        Assert.ThrowsException<ArgumentException>(()=>calculator.Factorial(-1));
    }
}