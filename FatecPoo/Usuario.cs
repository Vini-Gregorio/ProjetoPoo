using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; } // "Administrador" ou "Funcionário"
        public string Senha { get; set; }
    }
}
