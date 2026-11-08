
namespace MediSyncApi.Models
{
    public class DoseHistory
    {
        public int Id { get; set; }

        public int MedicineId { get; set; }

        public string MedicineName { get; set; } = string.Empty;

        public string ScheduledTime { get; set; } = string.Empty;

        public string DoseDate { get; set; } = string.Empty;

        public bool IsTaken { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
