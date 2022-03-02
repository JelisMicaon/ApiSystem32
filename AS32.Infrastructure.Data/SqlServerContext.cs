using AS32.Domain.Estoque.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using AS32.Domain.Financeiro.Cadastro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

namespace AS32.Infrastructure.Data
{
    public class SqlServerContext : DbContext
    {
        #region Contrutores
        public SqlServerContext(DbContextOptions options) : base(options) { }
        #endregion Contrutores

        #region Propriedades
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Entidade> Entidades { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        #endregion Propriedades

        #region Métodos Publicos
        public override int SaveChanges()
        {
            foreach (EntityEntry entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                else if (entry.State == EntityState.Modified)
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
            }
            return base.SaveChanges();
        }
        #endregion Métodos Publicos
    }
}