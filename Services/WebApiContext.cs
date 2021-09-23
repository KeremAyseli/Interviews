using Microsoft.EntityFrameworkCore;
using Interview.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Interview.Services
{
    class WebApiContext : DbContext
    {
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<SepetUrun> SepetUrun { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Interview;Integrated Security=True;");
        }
        


    }

}