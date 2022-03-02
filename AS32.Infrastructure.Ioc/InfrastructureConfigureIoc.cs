using AS32.Application.Interfaces.Estoque.Cadastro;
using AS32.Application.Interfaces.Faturamento.Cadastro;
using AS32.Application.Interfaces.Financeiro.Cadastro;
using AS32.Application.Service.Estoque.Cadastro;
using AS32.Application.Service.Faturamento.Cadastro;
using AS32.Application.Service.Financeiro.Cadastro;
using AS32.Domain.Core.Interfaces.Repository.Estoque.Cadastro;
using AS32.Domain.Core.Interfaces.Repository.Faturamento.Cadastro;
using AS32.Domain.Core.Interfaces.Repository.Financeiro.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Estoque.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Faturamento.Cadastro;
using AS32.Domain.Core.Interfaces.Services.Financeiro.Cadastro;
using AS32.Domain.Services.Services.Estoque.Cadastro;
using AS32.Domain.Services.Services.Faturamento.Cadastro;
using AS32.Domain.Services.Services.Financeiro.Cadastro;
using AS32.Infrastructure.Repository.Estoque.Cadastro;
using AS32.Infrastructure.Repository.Faturamento.Cadastro;
using AS32.Infrastructure.Repository.Financeiro.Cadastro;
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

            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceEntidade>().As<IServiceEntidade>();
            builder.RegisterType<ServiceFormaPagamento>().As<IServiceFormaPagamento>();

            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<RepositoryEntidade>().As<IRepositoryEntidade>();
            builder.RegisterType<RepositoryFormaPagamento>().As<IRepositoryFormaPagamento>();
        }
        #endregion Métodos Privados
    }
}