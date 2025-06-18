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
        private ListaDePrisoneiros tela;
        public TelaInicial telaInicial;  // deixa público para ser acessado de fora
        private void AbrirTela(Form Tela)
        {
            Tela.Show(); // ou ShowDialog() se quiser que a tela anterior fique travada
        }
        public TelaInicial()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // remove bordas e barra de título
            this.WindowState = FormWindowState.Maximized; // maximiza para tela cheia
            Label ListaPrisoneiros = new Label();
            ListaPrisoneiros.Text = "";              // sem texto
            ListaPrisoneiros.Size = new Size(357, 47);
            ListaPrisoneiros.Location = new Point(119, 559);
            ListaPrisoneiros.AutoSize = false;       // para respeitar o tamanho definido
            ListaPrisoneiros.BackColor = Color.Transparent;  // fundo transparente
            ListaPrisoneiros.Click += ListaPrisoneiros_Click;

            Label VerificarAnalises = new Label();
            VerificarAnalises.Text = "";              // sem texto
            VerificarAnalises.Size = new Size(357, 47);
            VerificarAnalises.Location = new Point(119, 559);
            VerificarAnalises.AutoSize = false;       // para respeitar o tamanho definido
            VerificarAnalises.BackColor = Color.Transparent;  // fundo transparente
            VerificarAnalises.Click += VerificarAnalises_Click;

            Label PrisõesECelas = new Label();
            PrisõesECelas.Text = "";              // sem texto
            PrisõesECelas.Size = new Size(357, 47);
            PrisõesECelas.Location = new Point(119, 559);
            PrisõesECelas.AutoSize = false;       // para respeitar o tamanho definido
            PrisõesECelas.BackColor = Color.Transparent;  // fundo transparente
            PrisõesECelas.Click += PrisõesECelas_Click;

            this.Controls.Add(ListaPrisoneiros);
            MostrarTotalDetentos();
            string RelatorioPen = "50";
            // lblRelatorioPen.Text = $"{RelatorioPen}";
            string CelaDis = "40";
            // lblCelaDis.Text = $"{CelaDis}";

            PictureBox Sair = new PictureBox();
            Sair.Name = "Sair";
            Sair.Location = new Point(1832, 987);
            Sair.Size = new Size(71, 74);
            Sair.BackColor = Color.Transparent;
            Sair.SizeMode = PictureBoxSizeMode.StretchImage;
            Sair.Cursor = Cursors.Hand; // opcional: mostra cursor de mão ao passar por cima
                                        // Adiciona o evento de clique
            Sair.Click += Sair_Click;

            // Adiciona ao formulário
            this.Controls.Add(Sair);

        }
        public void AtualizarContador(int quantidade)
        {
            label1.Text = quantidade.ToString();
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
        private void AtivarTelaCheia()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas e título
            this.WindowState = FormWindowState.Normal;   // Importante para aplicar Bounds depois
            this.Bounds = Screen.PrimaryScreen.Bounds;   // Ocupa toda a tela, inclusive barra de tarefas
            this.TopMost = true;                         // Garante que fique acima de tudo
        }
        private void SairDaTelaCheia()
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600); // ou qualquer tamanho que quiser
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

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F11)
                {
                    if (this.FormBorderStyle == FormBorderStyle.None)
                        SairDaTelaCheia();
                    else
                        AtivarTelaCheia();
                }
            };


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



        private void lblRegPrisioneiro_Click(object sender, EventArgs e)
        {

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



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
        private void ListaPrisoneiros_Click(object sender, EventArgs e)
        {
            

            ListaDePrisoneiros lista = new ListaDePrisoneiros(this); // passando a referência da tela inicial
            lista.Show();
        }
        private void VerificarAnalises_Click(object sender, EventArgs e)
        {

        }
        private void PrisõesECelas_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
