using Microsoft.EntityFrameworkCore;

namespace ProAgile.WebAPI.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
}
}