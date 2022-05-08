namespace DotNet6Api.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? RoleType { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = String.Empty;
        public string? Password { get; set; }
        public bool IsDeactive { get; set; }
        public bool IsLock { get; set; }
    }
}
