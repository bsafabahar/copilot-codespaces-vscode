using Microsoft.EntityFrameworkCore;
using LetterManagement.Models;

namespace LetterManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Letter> Letters { get; set; }
    }
}