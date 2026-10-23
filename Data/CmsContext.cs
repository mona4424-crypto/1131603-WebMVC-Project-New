using Microsoft.EntityFrameworkCore;
using project.Models;
namespace project.Data
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options)
        {
        }

        //Dbset<改成對應的model> 再改成自己的table
        public DbSet<Bird> TableBirds1131603 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}
