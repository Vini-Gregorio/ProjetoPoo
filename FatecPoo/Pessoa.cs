using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatecPoo
{
    public class Pessoa
    {
        public int Id { get; set; }  // Você pode incrementar isso manualmente
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public DateTime DataDeRegistro { get; set; } = DateTime.Now;
        public string Regime { get; set; }
        public string Perigo { get; set; }
        public string PerfilPsicologico { get; set; }
        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - Nascimento.Year;
                if (Nascimento > hoje.AddYears(-idade)) idade--;
                return idade;
            }
        }
    }
}
