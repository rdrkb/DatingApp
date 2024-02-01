
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateOnly Created { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public DateOnly LastActive { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Photo> Photos { get; set; } = new ();

        // public int GetAge()
        // {
        //     return DateOfBirth.CalcuateAge();
        // }
    }
}
