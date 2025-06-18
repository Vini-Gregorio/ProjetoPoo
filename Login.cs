using MySql.Data.MySqlClient;
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

    public partial class Login : Form
    {
        Label lblUsuario;
        Label lblSenha;

        string textoUsuario = "";
        string textoSenha = "";
        Label campoAtivo = null;
        bool senhaVisivel = false; // controle de estado
        System.Windows.Forms.Timer cursorTimer = new System.Windows.Forms.Timer();
        bool cursorVisible = false;
        private Label campoAnterior = null;



        private void AbrirTela(Form Tela)
        {
            Tela.Show(); // ou ShowDialog() se quiser que a tela anterior fique travada
        }
        public Login()
        {
            InitializeComponent();
           
            panel1.Enabled = false;
            panel1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None; // remove bordas e barra de título
            this.WindowState = FormWindowState.Maximized; // maximiza para tela cheia
            this.KeyPreview = true;
            this.KeyPress += Login_KeyPress;

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

            // Label para o nome de usuário
            lblUsuario = new Label();
            lblUsuario.Location = new Point(126, 417);
            lblUsuario.Size = new Size(300, 30);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.BackColor = Color.Transparent;
            FontStyle estilo = FontStyle.Bold | FontStyle.Italic;
            lblUsuario.Font = new Font("Arial", 12, estilo);
            lblUsuario.Click += (s, e) => campoAtivo = lblUsuario;
            lblUsuario.Cursor = Cursors.Hand;
            this.Controls.Add(lblUsuario);

            // Label para a senha
            lblSenha = new Label();
            lblSenha.Location = new Point(136, 586);
            lblSenha.Size = new Size(280, 30);
            lblSenha.ForeColor = Color.White;
            lblSenha.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Arial", 12, estilo);
            lblSenha.Click += (s, e) => campoAtivo = lblSenha;
            lblSenha.Cursor = Cursors.Hand;
            this.Controls.Add(lblSenha);
          

            Label Entrar = new Label();
            Entrar.Text = "";              // sem texto
            Entrar.Size = new Size(160, 39);
            Entrar.Location = new Point(203, 746);
            Entrar.AutoSize = false;       // para respeitar o tamanho definido
            Entrar.BackColor = Color.Transparent;  // fundo transparente
            Entrar.Cursor = Cursors.Hand;


            Entrar.Click += Entrar_Click;
            this.Controls.Add(Entrar);

            PictureBox btnMostrarSenha = new PictureBox();
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Location = new Point(414, 572);
            btnMostrarSenha.Size = new Size(53, 50);
            btnMostrarSenha.BackColor = Color.Transparent;
            btnMostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.Click += (s, e) =>
            lblSenha.BringToFront();
            lblUsuario.BringToFront();
            {
                // torna o texto visível ao invés de bolinhas


                // mostra o label da senha, se estava oculto
                lblSenha.Visible = true;
            };
            btnMostrarSenha.Click += BtnMostrarSenha_Click;
            // 3. Adiciona ao formulário
            this.Controls.Add(btnMostrarSenha);
            cursorTimer.Interval = 500;
            cursorTimer.Tick += CursorTimer_Tick;

            // Associa clique nas labels para ativar o cursor
            lblUsuario.Click += (s, e) => AtivarCampo(lblUsuario);
            lblSenha.Click += (s, e) => AtivarCampo(lblSenha);

            // Também, quando clicar fora (exemplo: no form), desativa o cursor
            this.Click += (s, e) => DesativarCursor();



        }
        private void AtivarCampo(Label label)
        {
            campoAtivo = label;
            cursorVisible = false;
            cursorTimer.Start();
        }

        private void DesativarCursor()
        {
            cursorTimer.Stop();

            if (campoAtivo != null)
            {
                // Mostra o texto sem o cursor
                if (campoAtivo == lblSenha)
                    campoAtivo.Text = new string('•', textoSenha.Length);
                else if (campoAtivo == lblUsuario)
                    campoAtivo.Text = textoUsuario;
            }

            campoAtivo = null;
        }

        private void CursorTimer_Tick(object? sender, EventArgs e)
        {
            if (campoAtivo == null) return;

            cursorVisible = !cursorVisible;

            if (campoAtivo == lblUsuario)
            {
                campoAtivo.Text = textoUsuario + (cursorVisible ? "|" : "");
            }
            else if (campoAtivo == lblSenha)
                if (senhaVisivel)
                    campoAtivo.Text = textoSenha + (cursorVisible ? "|" : "");
                else
                    campoAtivo.Text = new string('•', textoSenha.Length) + (cursorVisible ? "|" : "");
        }
        private void SetCampoAtivo(Label novoCampo)
        {
            if (campoAtivo == novoCampo) return;

            // Se já tinha campo ativo, para o timer e limpa cursor dele
            if (campoAtivo != null)
            {
                cursorTimer.Stop();
                // Remove o cursor piscante do campo antigo
                if (campoAtivo == lblUsuario)
                    campoAtivo.Text = textoUsuario;
                else if (campoAtivo == lblSenha)
                    campoAtivo.Text = new string('•', textoSenha.Length);
            }

            campoAtivo = novoCampo;

            // Inicia o timer para o novo campo
            if (campoAtivo != null)
            {
                cursorTimer.Start();
            }
        }
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (campoAtivo == null) return;

            if (campoAtivo == lblUsuario)
            {
                if (e.KeyChar == (char)Keys.Back && textoUsuario.Length > 0)
                {
                    textoUsuario = textoUsuario.Substring(0, textoUsuario.Length - 1);
                }
                else if (!char.IsControl(e.KeyChar))
                {
                    textoUsuario += e.KeyChar;
                }

                campoAtivo.Text = textoUsuario + (cursorVisible ? "|" : "");
            }
            else if (campoAtivo == lblSenha)
            {
                if (e.KeyChar == (char)Keys.Back && textoSenha.Length > 0)
                {
                    textoSenha = textoSenha.Substring(0, textoSenha.Length - 1);
                }
                else if (!char.IsControl(e.KeyChar))
                {
                    textoSenha += e.KeyChar;
                }

                if (senhaVisivel)
                    campoAtivo.Text = textoSenha + (cursorVisible ? "|" : "");
                else
                    campoAtivo.Text = new string('•', textoSenha.Length) + (cursorVisible ? "|" : "");
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

        private void Login_Load(object sender, EventArgs e)
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



        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string con = "server=127.0.0.1; user=root; database=prisionadm; password=";
                MySqlConnection mySqlConnection = new MySqlConnection(con);

                // Usa as variáveis com os textos digitados via Label
                string username = textoUsuario;
                string password = textoSenha;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Campo vazio");
                }
                else
                {
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario", mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    bool loginCorreto = false;

                    while (reader.Read())
                    {
                        if (username == reader.GetString("nome") && password == reader.GetString("senha"))
                        {
                            loginCorreto = true;
                            break;
                        }
                    }

                    reader.Close();
                    mySqlConnection.Close();

                    if (loginCorreto)
                    {
                        MessageBox.Show("--->>> Entrando -->>>");

                        // Troca de tela (se tiver essa função implementada)
                        AbrirTela(new TelaInicial());
                    }
                    else
                    {
                        MessageBox.Show("Login inválido :/");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=127.0.0.1; user=root; database=prisionadm; password=";
                using (MySqlConnection mySqlConnection = new MySqlConnection(con))
                {
                    string username = textoUsuario;
                    string password = textoSenha;

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Campo vazio");
                        return;
                    }

                    mySqlConnection.Open();

                    string query = "SELECT COUNT(*) FROM usuario WHERE nome=@nome AND senha=@senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nome", username);
                        cmd.Parameters.AddWithValue("@senha", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("--->>> Entrando -->>>");
                            TelaInicial tela = new TelaInicial();
                            tela.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login inválido :/");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;
            if (senhaVisivel)
            {
                lblSenha.Text = textoSenha;  // mostra a senha real
                panel1.Visible = false;
            }
            else
            {
                lblSenha.Text = new string('•', textoSenha.Length); // mostra bolinhas
                panel1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
