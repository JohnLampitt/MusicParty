using Microsoft.EntityFrameworkCore;
using ML.Model.Models;

namespace ML.Model.Contexts
{
    public class SongsContext : DbContext
    {
        private SongsContext()
        {
            
        }
        public SongsContext(DbContextOptions<SongsContext> options)
            : base(options)
        { }

        public DbSet<Song> Songs { get; set; }
    }
}