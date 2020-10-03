using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BuildWebAPPFromConsole.Data
{
    public class BookStoreContext : IdentityDbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {
                
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookGallery> BookGallery { get; set; }

        public DbSet<Language> language{ get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("",);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
