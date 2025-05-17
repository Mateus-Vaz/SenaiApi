using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Entidades;
using static System.Formats.Asn1.AsnWriter;

namespace SenaiApi.Contexto
{
    public class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola {  get; set; }
        public DbSet<Escola> Endereco { get; set; }
        public DbSet<Escola> Professor { get; set; }
        public DbSet<Escola> Classe { get; set; }
        public DbSet<Escola> Aluno { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=root;");
        }
    }
}
