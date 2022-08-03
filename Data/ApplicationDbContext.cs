using BulkybookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkybookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  //configuring db context
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
