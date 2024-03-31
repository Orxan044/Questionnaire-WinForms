namespace Questionnaire__WinForms.Models;

public class User
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Brithday { get; set; }

    public override string ToString() => $"{Name} {Surname}";


    public string a()
    {
        return "A";
    }
}
