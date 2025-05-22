using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
    class Detento : Pessoa
    {
        public RegimeTipo Regime { get; set; }
        public Pena Pena { get; set; }
        public EstadoEmocional EstadoEmocional { get; set; }
        public Cela Cela { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaidaPrevista { get; set; }
    }
}
