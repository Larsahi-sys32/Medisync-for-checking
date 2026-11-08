
namespace MediSyncApi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string LoginId { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int? Age { get; set; }

        public string EmergencyContact { get; set; } = string.Empty;

        public string Photo { get; set; } = string.Empty;
    }
}
