using ConsoleApp1;
namespace TestProject2;

[TestClass]
public class RegistrarTest
{
    [TestMethod]
    public void CanValidateEmail()
    {
        var registrar = new Registrar();

        Assert.IsTrue(registrar.EmailIsValid("alexeikirillov@mail.ru"));
    }
    
    [TestMethod]
    public void CanNotValidateEmail()
    {
        var registrar = new Registrar();

        Assert.IsFalse(registrar.EmailIsValid("@mail.ru"));
        Assert.IsFalse(registrar.EmailIsValid("alexeikirillov@"));
        Assert.IsFalse(registrar.EmailIsValid("alexeikirillov@.ru"));
        Assert.IsFalse(registrar.EmailIsValid("alexeikirillov@mail."));
        Assert.IsFalse(registrar.EmailIsValid("alexeikirillovmail.ru"));
        Assert.IsFalse(registrar.EmailIsValid("alex-eik#irill(ov@mail.ru"));
    }
}