using Microsoft.EntityFrameworkCore;
using Shared;
namespace Movie.API
{
    public class MovieDBContext : DbContext
    {
        public DbSet<MovieModel> MovieData {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=data.db");
        
    }
}