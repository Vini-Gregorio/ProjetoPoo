using FatecPoo;

namespace FatecPoo
{
    public partial class Form1 : Form
    {
        List<Pessoa> listadedetentos = new List<Pessoa>();
        private ListaDePrisoneiros telaLista;

        private static int contadorId = 1;
        public Form1(ListaDePrisoneiros tela)
        {
            InitializeComponent();

            telaLista = tela;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick; // <-- evento correto para clique duplo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNascimento_Click(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNascimento.Text = "";

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            DateTime nascimento;
            if (!DateTime.TryParse(txtNascimento.Text, out nascimento))
            {
                MessageBox.Show("Data de nascimento inválida.");
                return;
            }

            Pessoa p = new Pessoa
            {
                Id = contadorId++,
                Nome = txtNome.Text,
                Nascimento = nascimento,
                  Foto = pictureBox1.Image
                // DataDeRegistro é automático
            };

            listadedetentos.Add(p);
            telaLista.AtualizarLabelTelaInicial();
            telaLista.AdicionarNaLista(p); // Correto: chama o método da tela
            ExameCriminal exame = new ExameCriminal(p);
            exame.ShowDialog();
            MessageBox.Show("Detento adicionado.");
            LimparCampos();
        }

        private void Listar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Selecione uma imagem";
            dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                // Limpa a imagem antiga se houver
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                // Define nova imagem
                Image img = Image.FromFile(dialogo.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

