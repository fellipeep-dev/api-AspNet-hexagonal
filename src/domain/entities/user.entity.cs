namespace AspNetApi.Src.Domain.Entities;

public class UserEntity(string name, string email, DateOnly birthDate, string password)
{
  public Guid Id { get; private set; } = Guid.NewGuid();

  public string Name { get; private set; } = name;

  public string Email { get; private set; } = email;

  public DateOnly BirthDate { get; private set; } = birthDate;

  public string Password { get; private set; } = password;
}
