using AS32.Domain.Core.Interfaces.Repository.Base;
using AS32.Domain.Faturamento.Cadastro;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Repository.Faturamento.Cadastro
{
    public interface IRepositoryEntidade : IRepositoryBase<Entidade>
    {
        new Task<long?> Add(Entidade entidade);
    }
}