using AS32.Infrastructure.Data;
using AS32.Infrastructure.Ioc;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AS32.Presentation
{
    public class Startup
    {
        #region Contrutores
        public Startup(IConfiguration configuration)
            => Configuration = configuration;
        #endregion Contrutores

        #region Propriedades
        public IConfiguration Configuration { get; }
        #endregion Propriedades

        #region M�todos Publicos
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(Configuration["Connections:ConnectionString"]));
            services.AddSwaggerGen(c => c.SwaggerDoc(Configuration["VersionApplication"], new OpenApiInfo { Title = Configuration["TitleApplication"], Version = Configuration["VersionApplication"] }));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{Configuration["VersionApplication"]}/swagger.json", Configuration["TitleApplication"]));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        public void ConfigureContainer(ContainerBuilder builder)
            => builder.RegisterModule(new InfrastructureConfigureIoc());
        #endregion M�todos Publicos
    }
}