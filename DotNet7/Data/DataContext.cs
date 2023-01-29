using DotNet7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DotNet7.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {
            
        }
        public DbSet<Phone> phones { get; set; }
    }
}
