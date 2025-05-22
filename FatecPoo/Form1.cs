namespace FatecPoo
{
    public partial class Form1 : Form
    {
        List<Detento> listadedetentos = new List<Detento>();
        public Form1()
        {
            InitializeComponent();
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
            txtEmail.Text = "";
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Detento p = new Detento();
            int idade;
            if (!int.TryParse(txtNascimento.Text, out idade))
            {
                MessageBox.Show("Idade inválida. Digite apenas números.");
                return;
            }
            p.Nome = txtNome.Text;
            p.Nascimento = idade;
            p.Email = txtEmail.Text;

            listadedetentos.Add(p);

            MessageBox.Show(" Detento adicionado ");
            LimparCampos();

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            listDetentos.Items.Clear();

            foreach (var p in listadedetentos)
            {
                listDetentos.Items.Add($"Nome: {p.Nome}, Idade: {p.Nascimento}, Email: {p.Email}");
            }
            LimparCampos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int index = listDetentos.SelectedIndex;
            if (index >= 0)
            {
                listadedetentos.RemoveAt(index);
                MessageBox.Show("Pessoa removida!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa da lista.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int index = listDetentos.SelectedIndex;
            int idade;

            if (index >= 0)
            {
                if (!int.TryParse(txtNascimento.Text, out idade))
                {
                    MessageBox.Show("Idade inválida. Digite apenas números.");
                    return;
                }
                listadedetentos[index].Nome = txtNome.Text;
                listadedetentos[index].Email = txtEmail.Text;
                listadedetentos[index].Nascimento = idade;

            }
            else
            {
                MessageBox.Show("Selecione uma pessoa da lista.");
            }
            LimparCampos();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
