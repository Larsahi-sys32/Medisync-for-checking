
using MediSyncApi.Data;
using MediSyncApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediSyncApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoseHistoryController : ControllerBase
    {
        private readonly MediSyncContext _context;

        public DoseHistoryController(MediSyncContext context)
        {
            _context = context;
        }

        // GET: api/DoseHistory
        [HttpGet]
        public async Task<IActionResult> GetDoseHistory()
        {
            var history = await _context.DoseHistories
                .OrderByDescending(d => d.DoseDate)
                .ToListAsync();

            return Ok(history);
        }

        // POST: api/DoseHistory
        [HttpPost]
        public async Task<IActionResult> SaveDoseHistory(
            [FromBody] DoseHistory dose)
        {
            var existing = await _context.DoseHistories
                .FirstOrDefaultAsync(d =>
                    d.MedicineId == dose.MedicineId &&
                    d.DoseDate == dose.DoseDate &&
                    d.ScheduledTime == dose.ScheduledTime);

            if (existing == null)
            {
                _context.DoseHistories.Add(dose);
            }
            else
            {
                existing.IsTaken = dose.IsTaken;
                existing.MedicineName = dose.MedicineName;
                existing.UpdatedAt = DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();

            return Ok(dose);
        }
    }
}
