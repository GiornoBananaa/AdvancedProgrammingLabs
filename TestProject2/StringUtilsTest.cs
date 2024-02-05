namespace TestProject2;
using ConsoleApp1;
[TestClass]
public class StringUtilsTest
{
    [TestMethod]
    public void CanGetDigit()
    {
        Assert.AreEqual(5,"hw5ll4".GetFirstDigit());
        Assert.AreEqual(9,"owpkg90k".GetFirstDigit());
    }
    
    [TestMethod]
    public void CanNotGetDigitWithout()
    {
        Assert.ThrowsException<ArgumentException>(()=>"ge*!fwg-".GetFirstDigit());
    }
}