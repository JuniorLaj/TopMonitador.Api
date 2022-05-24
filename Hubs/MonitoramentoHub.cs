using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TopMonitador.Api.Hubs.Clients;
using TopMonitador.Api.Models;

namespace TopMonitador.Api.Hubs
{
    public class MonitoramentoHub : Hub, IMonitoramentoHub
    {
        public IHubContext<MonitoramentoHub> HubContext { get; }

        public MonitoramentoHub(IHubContext<MonitoramentoHub> hubContext)
        {
            HubContext = hubContext;
        }

        public async Task SendMessage(Localizacao localizacao, string grupoDestino)
        {
            await HubContext.Clients.All.SendAsync(grupoDestino, localizacao);
        }

        public async Task JoinGroup(string nomeGrupo)
        {
            await HubContext.Groups.AddToGroupAsync(Context.ConnectionId, nomeGrupo);
        }
    }
}
