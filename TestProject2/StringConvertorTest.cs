namespace TestProject2;

using ConsoleApp1;

[TestClass]
public class StringConvertorTest
{
    [TestMethod]
    public void CanConvertToInt()
    {
        var stringConvertor = new StringConvertor();

        Assert.AreEqual(62388,stringConvertor.ConvertToInt("62388"));
        Assert.AreEqual(0,stringConvertor.ConvertToInt("0"));
    }
    
    [TestMethod]
    public void CanNotConvertToInt()
    {
        var stringConvertor = new StringConvertor();

        Assert.ThrowsException<ArgumentException>(()=>stringConvertor.ConvertToInt("34-12"));
        Assert.ThrowsException<ArgumentException>(()=>stringConvertor.ConvertToInt("12561к"));
        Assert.ThrowsException<ArgumentException>(()=>stringConvertor.ConvertToInt("]12561"));
    }
}