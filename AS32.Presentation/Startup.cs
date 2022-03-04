using AS32.Infrastructure.Ioc;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

        #region Métodos Publicos
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.LoadIoc(Configuration);
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
            => builder.RegisterModule(new InfrastructureConfigureAutoFacIoc());
        #endregion Métodos Publicos
    }
}