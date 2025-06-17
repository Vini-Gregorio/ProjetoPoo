using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FatecPoo;
namespace FatecPoo
{
    public partial class ExameCriminal : Form
    {
        int paginaAtual = 1;
        private Pessoa pessoa;
        private Pessoa p;
        public string Regime { get; private set; }
        public string Perigo { get; private set; }
        public ExameCriminal(Pessoa p)
        {
            InitializeComponent();
            pessoa = p;
        }



        private void AtualizarPagina()
        {
            label2.Text = $"Página {paginaAtual}";

            // Página 1: mostrar 1-5, esconder 6-10
            bool pagina1 = paginaAtual == 1;
            bool pagina2 = paginaAtual == 2;

            groupBox1.Visible = pagina1;
            groupBox2.Visible = pagina1;
            groupBox3.Visible = pagina1;
            groupBox4.Visible = pagina1;
            groupBox5.Visible = pagina1;

            groupBox6.Visible = pagina2;
            groupBox7.Visible = pagina2;
            groupBox8.Visible = pagina2;
            groupBox9.Visible = pagina2;
            groupBox10.Visible = pagina2;
        }
        private int VerificarPontuacao(GroupBox grupo)
        {
            foreach (Control controle in grupo.Controls)
            {
                if (controle is RadioButton radio && radio.Checked && radio.Tag != null)
                {
                    return Convert.ToInt32(radio.Tag);
                }
            }
            return 0; // Nenhuma alternativa marcada
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pontuacaoTotal = 0;

            pontuacaoTotal += VerificarPontuacao(groupBox1);
            pontuacaoTotal += VerificarPontuacao(groupBox2);
            pontuacaoTotal += VerificarPontuacao(groupBox3);
            pontuacaoTotal += VerificarPontuacao(groupBox4);
            pontuacaoTotal += VerificarPontuacao(groupBox5);
            pontuacaoTotal += VerificarPontuacao(groupBox6);
            pontuacaoTotal += VerificarPontuacao(groupBox7);
            pontuacaoTotal += VerificarPontuacao(groupBox8);
            pontuacaoTotal += VerificarPontuacao(groupBox9);
            pontuacaoTotal += VerificarPontuacao(groupBox10);

            // Agora sim, defina regime e perigo baseado na pontuação
            string regime, perigo;

            if (pontuacaoTotal <= 50)
            {
                regime = "Aberto";
                perigo = "Baixo";
            }
            else if (pontuacaoTotal <= 85)
            {
                regime = "Semiaberto";
                perigo = "Médio";
            }
            else
            {
                regime = "Fechado";
                perigo = "Alto";
            }

            // Atribua para a pessoa só agora
            pessoa.Regime = regime;
            pessoa.Perigo = perigo;

            DialogResult resultado = MessageBox.Show(
                $"Aberto/Baixo: <=50  Semiaberto/Médio: <=85  Fechado/Alto >85\n" +
                $"Pontuação total: {pontuacaoTotal}\n" +
                $"Regime recomendado: {regime}\n" +
                $"Nível de perigo: {perigo}\n\n" +
                $"Deseja iniciar o exame psicotécnico agora?",
                "Resultado do Exame",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                ExamePsicotecnico examePsico = new ExamePsicotecnico(pessoa);
                examePsico.ShowDialog();
                
            }
        }
        private void ExameCriminal_Load(object sender, EventArgs e)
        {
            AtualizarPagina();
            // Exemplo: GroupBox1
            radioButton1.Tag = 10;
            radioButton2.Tag = 0;
            radioButton3.Tag = 5;

            // GroupBox2 (ordem invertida)
            radioButton6.Tag = 10;
            radioButton5.Tag = 0;
            radioButton4.Tag = 5;

            // GroupBox3 (ordem invertida)
            radioButton9.Tag = 10;
            radioButton8.Tag = 0;
            radioButton7.Tag = 5;

            // GroupBox4 (ordem invertida)
            radioButton12.Tag = 10;
            radioButton11.Tag = 0;
            radioButton10.Tag = 5;

            // GroupBox5 (ordem invertida)
            radioButton15.Tag = 10;
            radioButton14.Tag = 0;
            radioButton13.Tag = 5;

            // GroupBox6 (ordem invertida)
            radioButton18.Tag = 10;
            radioButton17.Tag = 0;
            radioButton16.Tag = 5;

            // GroupBox7 (ordem invertida)
            radioButton21.Tag = 10;
            radioButton20.Tag = 0;
            radioButton19.Tag = 5;

            // Faça isso para todos os radioButtons...
            // GroupBox8 com apenas 2 alternativas
            radioButton24.Tag = 10;
            radioButton23.Tag = 0;

            // GroupBox9 com apenas 2 alternativas
            radioButton27.Tag = 0;
            radioButton26.Tag = 10;

            // GroupBox7 (ordem invertida)
            radioButton30.Tag = 0;
            radioButton29.Tag = 10;
            radioButton28.Tag = 5;


            // E assim por diante...
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (paginaAtual < 2)
            {
                paginaAtual++;
                AtualizarPagina();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                AtualizarPagina();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
