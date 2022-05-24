using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMonitador.Api.Models;

namespace TopMonitador.Api.Servicos.Interfaces
{
    public interface IMonitoramentoServico
    {
        Task<Localizacao> ObterLocalizacao();
        Task<bool> ReceberLocalizacaoUsuarioEnviarParaClientes(Localizacao message);

    }
}
