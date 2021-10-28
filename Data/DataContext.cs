using Microsoft.EntityFrameworkCore;
using ProAgile.WebAPI.Model;

namespace ProAgile.WebAPI.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Event> Events { get; set; }
}
}