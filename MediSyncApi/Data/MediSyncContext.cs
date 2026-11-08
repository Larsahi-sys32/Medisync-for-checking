
using MediSyncApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MediSyncApi.Data
{
    public class MediSyncContext : DbContext
    {
        public MediSyncContext(
            DbContextOptions<MediSyncContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
         public DbSet<DoseHistory> DoseHistories { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
