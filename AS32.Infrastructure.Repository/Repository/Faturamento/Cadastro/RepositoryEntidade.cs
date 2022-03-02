using AS32.Domain.Core.Interfaces.Repository.Faturamento.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using AS32.Infrastructure.Data;
using AS32.Infrastructure.Repository.Repository.Base;

namespace AS32.Infrastructure.Repository.Faturamento.Cadastro
{
    public class RepositoryEntidade : RepositoryBase<Entidade>, IRepositoryEntidade
    {
        #region Contrutores
        public RepositoryEntidade(SqlServerContext context) : base(context)
            => _context = context;
        #endregion Contrutores

        #region Propriedades
        private SqlServerContext _context;
        #endregion Propriedades
    }
}