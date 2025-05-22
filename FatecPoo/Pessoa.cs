using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
   public abstract class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        //idade nesse  contexto
        public int Nascimento { get; set; }


    }
}
