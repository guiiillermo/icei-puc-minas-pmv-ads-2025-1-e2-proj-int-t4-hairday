using System.Collections.Generic;
using System.Reflection.Emit;
using Hairday.Models;
using Microsoft.EntityFrameworkCore;

namespace Hairday.Controllers
{
    // Contexto
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Barbearia> Barbearias { get; set; }
        public DbSet<Barbeiro> Barbeiros { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Agendamento_Servico> Agendamento_Servicos { get; set; }
        public DbSet<Horario_Disponivel> Horario_Disponivel { get; set; }

        // Construtor que aceita DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendamento_Servico>()
                .HasKey(a => new { a.id_agendamento, a.id_servico });

            modelBuilder.Entity<Agendamento_Servico>()
                .HasOne(asg => asg.agendamento)
                .WithMany(ag => ag.agendamento_servicos)
                .HasForeignKey(asg => asg.id_agendamento)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Agendamento_Servico>()
                .HasOne(asg => asg.servico)
                .WithMany(s => s.agendamento_servicos)
                .HasForeignKey(asg => asg.id_servico)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Horario_Disponivel>()
                .HasOne(h => h.agendamento)
                .WithMany(a => a.horarios_disponiveis)
                .HasForeignKey(h => h.id_agendamento)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.email)
                .IsUnique();

            modelBuilder.Entity<Barbearia>()
                .HasIndex(b => b.email)
                .IsUnique();

            modelBuilder.Entity<Barbeiro>()
                .HasIndex(b => b.email)
                .IsUnique();
        }
    }
}
