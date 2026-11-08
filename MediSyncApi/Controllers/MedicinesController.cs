
using MediSyncApi.Data;
using MediSyncApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediSyncApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicinesController : ControllerBase
    {
        private readonly MediSyncContext _context;

        public MedicinesController(MediSyncContext context)
        {
            _context = context;
        }

        // GET: api/Medicines
        // Retrieve all medicines
        [HttpGet]
        public async Task<IActionResult> GetMedicines()
        {
            var medicines = await _context.Medicines.ToListAsync();

            return Ok(medicines);
        }

        // POST: api/Medicines
        // Add a new medicine
        [HttpPost]
        public async Task<IActionResult> AddMedicine(
            [FromBody] Medicine medicine)
        {
            _context.Medicines.Add(medicine);

            await _context.SaveChangesAsync();

            return Ok(medicine);
        }

        // PUT: api/Medicines/1
        // Update an existing medicine
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMedicine(
            int id,
            [FromBody] Medicine updatedMedicine)
        {
            var medicine = await _context.Medicines.FindAsync(id);

            if (medicine == null)
            {
                return NotFound();
            }

            medicine.Name = updatedMedicine.Name;
            medicine.Qty = updatedMedicine.Qty;
            medicine.Times = updatedMedicine.Times;
            medicine.Notes = updatedMedicine.Notes;
            medicine.IsActive = updatedMedicine.IsActive;

            await _context.SaveChangesAsync();

            return Ok(medicine);
        }

        // DELETE: api/Medicines/1
        // Delete a medicine
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicine(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);

            if (medicine == null)
            {
                return NotFound();
            }

            _context.Medicines.Remove(medicine);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
