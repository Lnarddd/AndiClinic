using AndiClinic.Models;
using Microsoft.EntityFrameworkCore;

namespace AndiClinic.Data
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
