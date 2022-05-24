using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopMonitador.Api.Models
{
    public class Localizacao
    {
        public int IdUsuario { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
