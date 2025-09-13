using System.ComponentModel.DataAnnotations;

namespace AspNetApi.Domain.Entities.User
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
    }
}