namespace Kirillov_KT_2;

public class ElementNotFoundException : Exception
{
    public override string Message =>
        "Element is not found";
}