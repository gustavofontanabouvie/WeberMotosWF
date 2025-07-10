using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeberMotosWF.Models;

namespace WeberMotosWF.DataBase
{
    public class OficinaDbContext : DbContext
    {
        public DbSet<Venda> vendas { get; set; }
        public DbSet<VendaItem> vendaItens { get; set; }
        public DbSet<Peca> pecas { get; set; }

        public OficinaDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ep-green-field-aclzn0fl-pooler.sa-east-1.aws.neon.tech;Port=5432;Database=neondb;Username=neondb_owner;Password=npg_8XNfUEgcCie2;Ssl Mode=Require;Trust Server Certificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
            .HasMany(v => v.Itens)
            .WithOne(vi => vi.Venda)
            .HasForeignKey(vi => vi.VendaId);

            modelBuilder.Entity<VendaItem>()
            .HasOne(vi => vi.Peca)
            .WithMany()
            .HasForeignKey(vi => vi.PecaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
