using AS32.Application.Dto.Estoque.Cadastro;
using AS32.Application.Dto.Faturamento.Cadastro;
using AS32.Application.Dto.Financeiro.Cadastro;
using AS32.Domain.Estoque.Cadastro;
using AS32.Domain.Faturamento.Cadastro;
using AS32.Domain.Financeiro.Cadastro;
using AS32.Infrastructure.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace AS32.Infrastructure.Ioc
{
    public static class InfrastructureConfigureServiceIoc
    {
        #region Métodos Publicos
        public static void LoadIoc(this IServiceCollection services, IConfiguration Configuration)
        {
            services.LoadDbContext(Configuration["Connections:ConnectionString"]);
            services.LoadSwagger(Configuration);
            services.LoadCollectionService();
        }
        #endregion Métodos Publicos

        #region Métodos Privados
        private static void LoadDbContext(this IServiceCollection services, string connectionString)
            => services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));

        private static void LoadSwagger(this IServiceCollection services, IConfiguration Configuration)
            => services.AddSwaggerGen(c => c.SwaggerDoc(Configuration["VersionApplication"], new OpenApiInfo { Title = Configuration["TitleApplication"], Version = Configuration["VersionApplication"] }));

        private static void LoadCollectionService(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new(
                mapperConfig =>
                {
                    mapperConfig.CreateMap<Produto, ProdutoDto>();
                    mapperConfig.CreateMap<ProdutoDto, Produto>();
                    mapperConfig.CreateMap<Entidade, EntidadeDto>();
                    mapperConfig.CreateMap<EntidadeDto, Entidade>();
                    mapperConfig.CreateMap<FormaPagamento, FormaPagamentoDto>();
                    mapperConfig.CreateMap<FormaPagamentoDto, FormaPagamento>();
                });
            services.AddSingleton(mapperConfiguration.CreateMapper());
        }
        #endregion Métodos Privados
    }
}