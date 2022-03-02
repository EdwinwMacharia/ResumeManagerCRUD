using Microsoft.EntityFrameworkCore;
using Resumemanager.Models;

namespace Resumemanager.Data
{
    public class ResumeDbContext:DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options):base(options)
        {

        }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }

    }
}
