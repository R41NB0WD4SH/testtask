using System;
using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask
{
	public class ApplicationContext : DbContext
	{
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=localhost;user=sa;password=mynewdb1;database=BG_TEST;TrustServerCertificate=true");
        //}


        public ApplicationContext()
        {
        }
    }
}

