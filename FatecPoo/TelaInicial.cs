using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; // precisa disso para o gradiente
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace FatecPoo
{
    public partial class TelaInicial : Form
    {
        private void AbrirTela(Form Tela)
        {
            Tela.Show(); // ou ShowDialog() se quiser que a tela anterior fique travada
        }
        public TelaInicial()
        {

            InitializeComponent();
            panel3.Paint += new PaintEventHandler(panel1_Paint);

            MostrarTotalDetentos();
            string RelatorioPen = "50";
            // lblRelatorioPen.Text = $"{RelatorioPen}";
            string CelaDis = "40";
            // lblCelaDis.Text = $"{CelaDis}";
        }

        private void MostrarTotalDetentos()
        {
            Conexao conexao = new Conexao();

            if (conexao.AbrirConexao())
            {
                string query = "SELECT COUNT(*) FROM usuario";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexao.ObterConexao());
                    int total = Convert.ToInt32(cmd.ExecuteScalar()); // Retorna um único valor

                    //lblNprisioneiro.Text = $"Total de usuários: {total}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao contar usuários: " + ex.Message);
                }
                finally
                {
                    conexao.FecharConexao();
                }
            }
        }
        private void panel6_Resize(object sender, EventArgs e)
        {
            panel6.Invalidate(); // força repintar
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentralizarLabel(Label lbl, Panel pnl)
        {
            lbl.Left = (pnl.Width - lbl.Width) / 2;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblListPrisoneiro_Click(object sender, EventArgs e)
        {
            ListaDePrisoneiros listaprisoneiros = new ListaDePrisoneiros(); // Instancia a outra tela
            listaprisoneiros.Show();
        }

        private void lblRegPrisioneiro_Click(object sender, EventArgs e)
        {

        }



        private void panel6_Paint(object sender, PaintEventArgs e)
        {

            // Cor personalizada branca
            Color Branco = Color.FromArgb(224, 224, 224);

            // Define o retângulo que cobre toda a área do painel
            Rectangle retanguloMaior = new Rectangle(0, 0, panel6.Width, panel6.Height);

            // Cria o gradiente da esquerda para a direita
            using (LinearGradientBrush brush = new LinearGradientBrush(
                retanguloMaior,
                Branco, // Não será usado diretamente com InterpolationColors
                Color.Black, // Não será usado diretamente com InterpolationColors
                LinearGradientMode.Horizontal))
            {
                // Controla onde cada cor aparece no gradiente
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Branco, Color.Gray, Color.Black };
                blend.Positions = new float[] { 0f, 0.3f, 1f }; // Branco até 20%, depois preto

                brush.InterpolationColors = blend;
                // Preenche o painel com o gradiente
                e.Graphics.FillRectangle(brush, panel6.ClientRectangle);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

            // Definindo as três cores
            Color topo = Color.PaleVioletRed;
            Color meio = Color.Red;
            Color fundo = Color.FromArgb(48, 0, 0); // Vinho

            // Cria o retângulo do tamanho do painel
            Rectangle rect = panel3.ClientRectangle;

            // Cria o gradiente na vertical
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, topo, fundo, LinearGradientMode.Vertical))
            {
                // Define a transição entre as cores
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { topo, meio, fundo
};
                blend.Positions = new float[] { 0.0f, 0.5f, 1.0f }; // Topo = 0%, meio = 50%, fundo = 100%

                brush.InterpolationColors = blend;

                // Preenche o painel com o gradiente
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }





        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDePrisoneiros listaDePrisoneiros = new ListaDePrisoneiros(); // instanciando a nova tela
            listaDePrisoneiros.Show(); // abre sem bloquear a tela atual
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaDePrisao listaDePrisao = new ListaDePrisao();
            listaDePrisao.Show();
        }
    }
}
