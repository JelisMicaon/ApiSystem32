using AS32.Domain.Core.Interfaces.Repository.Financeiro.Cadastro;
using AS32.Domain.Financeiro.Cadastro;
using AS32.Infrastructure.Data;
using AS32.Infrastructure.Repository.Repository.Base;

namespace AS32.Infrastructure.Repository.Financeiro.Cadastro
{
    public class RepositoryFormaPagamento : RepositoryBase<FormaPagamento>, IRepositoryFormaPagamento
    {
        #region Contrutores
        public RepositoryFormaPagamento(SqlServerContext context) : base(context)
            => _context = context;
        #endregion Contrutores

        #region Propriedades
        private SqlServerContext _context;
        #endregion Propriedades
    }
}