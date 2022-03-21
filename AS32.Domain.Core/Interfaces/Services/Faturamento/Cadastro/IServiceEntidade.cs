using AS32.Domain.Core.Interfaces.Services.Base;
using AS32.Domain.Faturamento.Cadastro;
using System.Threading.Tasks;

namespace AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro
{
    public interface IServiceEntidade : IServiceBase<Entidade>
    {
        new Task<long?> Add(Entidade entity);
    }
}