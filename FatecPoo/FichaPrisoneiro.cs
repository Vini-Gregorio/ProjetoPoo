using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            this.MouseDown += FichaPrisoneiro_MouseDown;
            pessoa = p;
            this.regime = regime;
            this.perigo = perigo;
            this.FormBorderStyle = FormBorderStyle.None; // remove a borda e barra do Windows
            label2.Text = $"Nome: {pessoa.Nome}\n" +
                          $"Nascimento: {pessoa.Nascimento.ToShortDateString()}\n" +
                          $"Data de Registro: {pessoa.DataDeRegistro:g}\n" +
                          $"Idade: {pessoa.Idade} anos";

            AtualizarLabels();
            Label Fechar = new Label();
            Fechar.Text = "";              // sem texto
            Fechar.Size = new Size(34, 33);
            Fechar.Location = new Point(551, 12);
            Fechar.AutoSize = false;       // para respeitar o tamanho definido
            Fechar.BackColor = Color.Transparent;  // fundo transparente
            Fechar.Click += Fechar_Click;
            Fechar.Cursor = Cursors.Hand; // opcional: mostra cursor de mão ao passar por cima
            this.Controls.Add(Fechar); // Adiciona o label à tela
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick; // <-- evento correto para clique duplo
            if (pessoa.Foto != null)
            {
                pictureBox1.Image = pessoa.Foto;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        // Reutiliza o construtor principal passando os dados já contidos na pessoa
        public FichaPrisoneiro(Pessoa p) : this(p, p.Regime, p.Perigo)
        {
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes da API do Windows
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void AtualizarLabels()
        {
            label3.Text = regime ?? "Não definido";
            label4.Text = perigo ?? "Não definido";
            label5.Text = pessoa.PerfilPsicologico;


            label5.MaximumSize = new Size(groupBox2.Width - 525, 134); // Ajusta à largura do GroupBox com uma margem

            // Define a posição manualmente na tela
            label5.Location = new Point(3, 25); // Altere os valores conforme o layout da tela

            label5.TextAlign = ContentAlignment.TopLeft;

            // Cor do nível de perigo (label4)
            if (perigo == "Baixo")
            {
                label4.ForeColor = Color.Green;
            }
            else if (perigo == "Médio")
            {
                label4.ForeColor = Color.Orange;
            }
            else if (perigo == "Alto")
            {
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Black; // padrão
            }
            // Cor do perfil psicológico (label5)
            if (pessoa.PerfilPsicologico.Contains("Estável"))
            {
                label5.ForeColor = Color.Green;
            }
            else if (pessoa.PerfilPsicologico.Contains("Riscos Moderados"))
            {
                label5.ForeColor = Color.Orange;
            }
            else if (pessoa.PerfilPsicologico.Contains("Alto Grau de Instabilidade"))
            {
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Black; // cor padrão caso não reconheça
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void FichaPrisoneiro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Selecione uma imagem";
            dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                Image img = Image.FromFile(dialogo.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                pessoa.Foto = img; // <- atualiza na classe
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

