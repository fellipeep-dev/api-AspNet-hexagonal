namespace Application.Dtos.User
{
    public class UpdateUserDto
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }

        public string? Email { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string? Password { get; set; }
    }
}