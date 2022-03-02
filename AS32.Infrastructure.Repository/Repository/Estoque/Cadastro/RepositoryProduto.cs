using AS32.Domain.Core.Interfaces.Repository.Estoque.Cadastro;
using AS32.Domain.Estoque.Cadastro;
using AS32.Infrastructure.Data;
using AS32.Infrastructure.Repository.Repository.Base;

namespace AS32.Infrastructure.Repository.Estoque.Cadastro
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        #region Contrutores
        public RepositoryProduto(SqlServerContext context) : base(context)
            => _context = context;
        #endregion Contrutores

        #region Propriedades
        private SqlServerContext _context;
        #endregion Propriedades
    }
}