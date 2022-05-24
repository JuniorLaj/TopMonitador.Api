using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMonitador.Api.Models;
using TopMonitador.Api.Servicos.Interfaces;

namespace TopMonitador.Api.Controllers
{
    [Route("monitoramento")]
    [ApiController]
    public class MonitoramentoController : Controller
    {
        #region Propriedades
        protected IMonitoramentoServico MonitoramentoServico { get; set; }
        #endregion

        #region Construtor
        public MonitoramentoController(IMonitoramentoServico monitoramentoServico)
        {
            MonitoramentoServico = monitoramentoServico;
        }
        #endregion

        #region Ações
        [HttpPost]
        [Route("receber")]
        [Produces(typeof(Localizacao))]
        public async Task<IActionResult> ReceberLocalizacao([FromBody] Localizacao localizacao)
        {
            return Ok(MonitoramentoServico.ReceberLocalizacaoUsuarioEnviarParaClientes(localizacao));
        }

        [HttpGet]
        [Route("obter-localizacao")]
        [Produces(typeof(Localizacao))]

        public async Task<IActionResult> ObterLocalizacao()
        {
            return Ok(MonitoramentoServico.ObterLocalizacao());
        }
        #endregion
    }
}
