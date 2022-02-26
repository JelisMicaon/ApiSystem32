using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AS32.Presentation
{
    public class Program
    {
        #region M�todos Publicos
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
                                              .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        #endregion M�todos Publicos
    }
}