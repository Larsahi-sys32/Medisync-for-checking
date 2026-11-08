
namespace MediSyncApi.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Qty { get; set; } = 1;

        // Store multiple reminder times as text for now.
        public string Times { get; set; } = "08:00";

        public string Notes { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
