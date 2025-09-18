namespace Application.Dtos.User
{
    public class CreateUserDto(string name, string email, DateOnly birthDate, string password)
    {
        public string Name { get; set; } = name;

        public string Email { get; set; } = email;

        public DateOnly BirthDate { get; set; } = birthDate;

        public string Password { get; set; } = password;
    }
}