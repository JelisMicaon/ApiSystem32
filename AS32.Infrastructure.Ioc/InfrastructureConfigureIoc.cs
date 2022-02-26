using AS32.Application.Interfaces.Estoque.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using AS32.Application.Interfaces.Financeiro.Cadastro;
using AS32.Application.Service.Estoque.Cadastro;
using AS32.Application.Service.Faturamento.Cadastro;
using AS32.Application.Service.Financeiro.Cadastro;
using Autofac;

namespace AS32.Infrastructure.Ioc
{
    public class InfrastructureConfigureIoc : Module
    {
        #region Métodos Override
        protected override void Load(ContainerBuilder builder)
            => LoadApplicationIoc(builder);
        #endregion Métodos Override

        #region Métodos Privados
        private static void LoadApplicationIoc(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceEntidade>().As<IApplicationServiceEntidade>();
            builder.RegisterType<ApplicationServiceFormaPagamento>().As<IApplicationServiceFormaPagamento>();
        }
        #endregion Métodos Privados
    }
}