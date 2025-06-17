using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatecPoo
{
    public partial class FichaPrisoneiro : Form
    {
        private Pessoa pessoa;
        private string regime;
        private string perigo;
        public FichaPrisoneiro(Pessoa p, string regime, string perigo)
        {
            InitializeComponent();
            pessoa = p;
            this.regime = regime;
            this.perigo = perigo;

            label2.Text = $"Nome: {pessoa.Nome}\n" +
                          $"Nascimento: {pessoa.Nascimento.ToShortDateString()}\n" +
                          $"Data de Registro: {pessoa.DataDeRegistro:g}\n" +
                          $"Idade: {pessoa.Idade} anos";

            AtualizarLabels();
        }
        // Reutiliza o construtor principal passando os dados já contidos na pessoa
        public FichaPrisoneiro(Pessoa p) : this(p, p.Regime, p.Perigo)
        {
        }

        private void AtualizarLabels()
        {
            label3.Text = regime ?? "Não definido";
            label4.Text = perigo ?? "Não definido";
            label5.Text = pessoa.PerfilPsicologico;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FichaPrisoneiro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
