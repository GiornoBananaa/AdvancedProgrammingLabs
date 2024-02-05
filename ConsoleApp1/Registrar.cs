namespace ConsoleApp1;

public class Registrar
{
    public bool EmailIsValid(string email)
    {
        string[] emailParts =  email.Split('@');
        if (emailParts.Length != 2) return false;
        string domain = emailParts[1];
        if (string.IsNullOrWhiteSpace(emailParts[0])) return false;
        if (string.IsNullOrWhiteSpace(emailParts[1])) return false;
        
        foreach (char i in email)
        {
            if (!char.IsLetterOrDigit(i) && i != '@' && i != '.')
            {
                return false;
            }
        }
        
        if (domain.Length < 2 || !domain.Contains(".") || domain.Split(".").Length !=2 
            ||  domain.EndsWith(".") || domain.StartsWith("."))
        {
            return false;
        }
        
        return true;
    }
}