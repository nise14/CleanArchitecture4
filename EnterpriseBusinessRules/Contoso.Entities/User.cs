using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class User : IEntity
{
    public User()
    {
        DateRegister = DateTime.UtcNow;
    }

    public Guid Id { get; set; }
    public string Name { get; private set; } = null!;
    public DateTime BirthDate { get; private set; }
    public string Email { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public DateTime DateRegister { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetBirthDate(DateTime birthDate)
    {
        ValidateAge(birthDate);
        BirthDate = birthDate;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public void SetPassword(string password)
    {
        Password = password;
    }

    private void ValidateAge(DateTime date)
    {
        var local = DateTime.Now;
        int age = 0;

        age = local.Year - date.Year;

        if (local.DayOfYear < date.DayOfYear)
        {
            age = age - 1;
        }

        if (age < 16)
        {
            throw new Exception("Age not permitted for register in these courses");
        }
    }
}
