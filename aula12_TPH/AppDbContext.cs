using Microsoft.EntityFrameworkCore;

namespace aula12_TPH
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasDiscriminator<string>("PessoaTipo")
                .HasValue<Aluno>("Aluno")
                .HasValue<Professor>("Professor");
        }
    }
}