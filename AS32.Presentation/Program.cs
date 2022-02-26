using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AS32.Presentation
{
    public class Program
    {
        #region Métodos Publicos
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        #endregion Métodos Publicos
    }
}