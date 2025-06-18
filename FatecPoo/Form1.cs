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
                Nascimento = nascimento
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
    }
}

