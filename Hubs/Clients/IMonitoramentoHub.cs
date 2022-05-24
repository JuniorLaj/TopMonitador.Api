using System.Threading.Tasks;
using TopMonitador.Api.Models;

namespace TopMonitador.Api.Hubs.Clients
{
    public interface IMonitoramentoHub
    {
        //Task SendGeoLocation(string latitude, string longitude);
        public Task SendMessage(Localizacao message, string grupoDestino);
    }
}
