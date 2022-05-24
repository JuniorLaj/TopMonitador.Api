using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMonitador.Api.Hubs;
using TopMonitador.Api.Hubs.Clients;
using TopMonitador.Api.Models;
using TopMonitador.Api.Servicos.Interfaces;

namespace TopMonitador.Api.Servicos
{
    public class MonitoramentoServico : IMonitoramentoServico
    {

        private readonly IMonitoramentoHub _monitoramentoHub;

        public MonitoramentoServico(IMonitoramentoHub monitoramentoHub)
        {
            _monitoramentoHub = monitoramentoHub;
        }

        public async Task<Localizacao> ObterLocalizacao()
        {
            return new Localizacao
            {
                IdUsuario = 10,
            };
        }

        public async Task<bool> ReceberLocalizacaoUsuarioEnviarParaClientes(Localizacao message)
        {
            await _monitoramentoHub.SendMessage(message, "receiveMessage");
            return true;
        }
    }
}
