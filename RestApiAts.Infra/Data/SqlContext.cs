using Microsoft.EntityFrameworkCore;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiAts.Infra.Data
{
    public class SqlContext : DbContext
    {

        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }


        public DbSet<Candidatura> Candidaturas { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=MudarSenha123;Initial Catalog=Ats;Persist Security Info=True;User ID=sa;Data Source=localhost,1433");
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
