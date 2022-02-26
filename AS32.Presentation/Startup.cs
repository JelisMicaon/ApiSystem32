using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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

        #region Métodos Publicos
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
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
        #endregion Métodos Publicos
    }
}