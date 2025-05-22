using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
    class Cela
    { 
       public int Id { get; set; }
       public string Nome { get; set; }
        public int Capacidade { get; set; }
        public int OcupacaoAtual { get; set; }

        public Cela(string nome)
        {
            Nome = nome;
        }
    }
}
