using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Actio.Common.Services
{
    public class ServiceHost : IServiceHost
    {
        private readonly IWebHost _webHost;
        public ServiceHost(IWebHost webHost)
        {
            _webHost = webHost;
        }
        public void Run() => _webHost.Run();
        public static HostBuilder Create<TStartup>(string[] args) where TStartup : class
        {
            Console.Title = typeof(TStartup).Namespace;
            var config = new ConfigurationBuilder().AddEnvironmentVariables().AddCommandLine(args).Build();
            var webHostBuilder = WebHost.CreateDefaultBuilder(args)
            .UseConfiguration(config).UseStartup<TStartup>();
            return new HostBuilder(webHostBuilder.Build());
        }
    }
}