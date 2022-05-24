using Microsoft.Extensions.DependencyInjection;
using TopMonitador.Api.Hubs;
using TopMonitador.Api.Hubs.Clients;
using TopMonitador.Api.Servicos;
using TopMonitador.Api.Servicos.Interfaces;

namespace TopMonitador.Api.Core
{
    public static class DIStartup
    {
        public static void AddDICustomizado(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddScoped<IMonitoramentoServico, MonitoramentoServico>();
            services.AddScoped<IMonitoramentoHub, MonitoramentoHub>();
        }
    }
}
