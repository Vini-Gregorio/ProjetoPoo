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
    public partial class ExamePsicotecnico : Form
    {
        int paginaAtual = 1;

        private Pessoa pessoa;
        public ExamePsicotecnico(Pessoa p)
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

            string perfil;

            if (pontuacaoTotal <= 50)
            {
                perfil = "Perfil Psicológico Estável\r\nDemonstra controle emocional, empatia, racionalidade e cooperação. Apto psicologicamente.";
            }
            else if (pontuacaoTotal <= 85)
            {
                perfil = "Perfil com Riscos Moderados\r\nApresenta traços de impulsividade ou estresse emocional sob pressão. Necessita acompanhamento ou avaliação complementar.";
            }
            else
            {
                perfil = "Perfil com Alto Grau de Instabilidade\r\nIndica agressividade, dificuldade de adaptação e baixa empatia. Inapto para atividades que exijam equilíbrio emocional.";
            }
            pessoa.PerfilPsicologico = perfil;
            DialogResult resultado = MessageBox.Show(
    $"0 a 50 pontos – Perfil Psicológico Estável. 51 a 85 pontos – Perfil com Riscos Moderados. Acima de 85 pontos – Perfil com Alto Grau de Instabilidade.\n\n" +
    $"Pontuação total: {pontuacaoTotal}\n\n" +
    $"Perfil: {perfil}\n\n" +
    $"Finalizar?",
    "Resultado do Exame",
    MessageBoxButtons.OK);

            if (resultado == DialogResult.OK)
            {
                this.Close();
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
            radioButton12.Tag =0;
            radioButton11.Tag = 10;
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
            radioButton21.Tag = 0;
            radioButton20.Tag = 10;
            radioButton19.Tag = 5;

            // Faça isso para todos os radioButtons...
            // GroupBox8 com apenas 2 alternativas
            radioButton24.Tag = 10;
            radioButton23.Tag = 0;
            radioButton22.Tag = 5;
            // GroupBox9 com apenas 2 alternativas
            radioButton27.Tag = 10;
            radioButton26.Tag = 0;
            radioButton25.Tag = 5;
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
