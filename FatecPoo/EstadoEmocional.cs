using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
    class EstadoEmocional
    {
        public string? Observacao { get; set; }
        public int NivelDeRisco { get; set; } // 0 (normal) até 5 (alto risco)
    }
}
