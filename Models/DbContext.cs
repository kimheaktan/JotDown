using Microsoft.EntityFrameworkCore;

namespace Jot.Models
{
    public class JotContext : DbContext
    {
        public JotContext(DbContextOptions options) : base(options) { } 

        public DbSet<Folder> Folders { get; set; } 
        public DbSet<Note> Notes {get;set;}


    }
}