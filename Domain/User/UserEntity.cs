using System.ComponentModel.DataAnnotations;

namespace AspNetApi.Domain.User
{
    public class UserEntity(string name, string email, DateOnly birthDate, string password)
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public string Name { get; private set; } = name;

        [Required]
        public string Email { get; private set; } = email;

        [Required]
        public DateOnly BirthDate { get; private set; } = birthDate;

        [Required]
        public string Password { get; private set; } = password;
        
        public void Update(string? name, string? email, DateOnly? birthDate, string? password)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;

            if (!string.IsNullOrWhiteSpace(email))
                Email = email;

            if (birthDate.HasValue)
                BirthDate = birthDate.Value;

            if (!string.IsNullOrWhiteSpace(password))
                Password = password;
        }
    }
}