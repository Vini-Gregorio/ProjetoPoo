
using FatecPoo;
using System.Runtime.InteropServices;


namespace FatecPoo
{
    

    public partial class ListaDePrisoneiros : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public TelaInicial telaInicial; // essa propriedade precisa estar pública ou acessível



        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private List<Pessoa> listaCompleta = new List<Pessoa>();//lista interna completa
        public ListaDePrisoneiros(TelaInicial tela2)
        {
            InitializeComponent();
            // **Aqui adiciona as colunas**
            this.MouseDown += ListaDePrisoneiros_MouseDown;
            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 300, HorizontalAlignment.Left);
            listView1.Columns.Add("Idade", 174, HorizontalAlignment.Center);
            listView1.Columns.Add("Nascimento", 174, HorizontalAlignment.Center);
            listView1.Columns.Add("Data de Registro", 174, HorizontalAlignment.Center);
            this.FormBorderStyle = FormBorderStyle.None; // remove a borda e barra do Windows
            telaInicial = tela2;

            telaInicial.label1.Text = listView1.Items.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void AtualizarLabelTelaInicial()
        {
        
                telaInicial?.AtualizarContador(listView1.Items.Count);
            
        }
        public void AdicionarNaLista(Pessoa p)
        {
            listaCompleta.Add(p);  // salva na lista completa para buscas
            ListViewItem item = new ListViewItem(p.Id.ToString());
            item.SubItems.Add(p.Nome);
            item.SubItems.Add(p.Idade.ToString());
            item.SubItems.Add(p.Nascimento.ToShortDateString());
            item.SubItems.Add(p.DataDeRegistro.ToString("g"));

            item.Tag = p;  // <-- Adicione esta linha!

            listView1.Items.Add(item);
            AtualizarLabelTelaInicial(); // ? garante que o label da tela inicial seja atualizado
        }

        private void AtualizarListView(List<Pessoa> pessoas)
        {
            listView1.Items.Clear();
            foreach (var p in pessoas)
            {
                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Nome);
                item.SubItems.Add(p.Idade.ToString());
                item.SubItems.Add(p.Nascimento.ToShortDateString());
                item.SubItems.Add(p.DataDeRegistro.ToString("g"));
                item.Tag = p; // IMPORTANTE para poder acessar depois
                listView1.Items.Add(item);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrisonerRegister_Click(object sender, EventArgs e)
        {
            Form1 formCadastro = new Form1(this); // dentro do ListaDePrisioneiros
            formCadastro.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regimeSelecionado = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(regimeSelecionado))
            {
                // Se nada foi selecionado, mostra tudo
                AtualizarListView(listaCompleta);
            }
            else
            {
                // Filtra por regime (campo pessoa.Regime)
                var filtrados = listaCompleta
                    .Where(p => p.Regime == regimeSelecionado)
                    .ToList();

                AtualizarListView(filtrados);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termo = textBox1.Text.Trim().ToLower();

            List<Pessoa> filtrados;

            if (termo.StartsWith("id:"))
            {
                string valor = termo.Substring(3).Trim();
                if (int.TryParse(valor, out int idBusca))
                {
                    filtrados = listaCompleta.Where(p => p.Id == idBusca).ToList();
                }
                else
                {
                    filtrados = new List<Pessoa>();
                }
            }
            else if (termo.StartsWith("idade:"))
            {
                string valor = termo.Substring(6).Trim();
                if (int.TryParse(valor, out int idadeBusca))
                {
                    filtrados = listaCompleta.Where(p => p.Idade == idadeBusca).ToList();
                }
                else
                {
                    filtrados = new List<Pessoa>();
                }
            }
            else
            {
                // Pesquisa normal nos campos: Nome, Nascimento e DataDeRegistro em formato texto
                filtrados = listaCompleta.Where(p =>
                    p.Nome.ToLower().Contains(termo) ||
                    p.Idade.ToString().Contains(termo) ||
                    p.Nascimento.ToShortDateString().Contains(termo) ||
                    p.DataDeRegistro.ToString("g").Contains(termo)
                ).ToList();
            }

            AtualizarListView(filtrados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comandos formComandos = new Comandos();
            formComandos.Show();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Pega o ListViewItem selecionado
                var item = listView1.SelectedItems[0];

                // Recupera o objeto Pessoa armazenado no Tag
                Pessoa p = item.Tag as Pessoa;

                if (p != null)
                {
                    FichaPrisoneiro ficha = new FichaPrisoneiro(p);
                    ficha.ShowDialog();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string perigoSelecionado = comboBox3.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(perigoSelecionado))
            {
                // Se nada foi selecionado, mostra tudo
                AtualizarListView(listaCompleta);
            }
            else
            {
                // Filtra por perigo (campo pessoa.Regime)
                var filtrados = listaCompleta
                    .Where(p => p.Perigo == perigoSelecionado)
                    .ToList();

                AtualizarListView(filtrados);
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string perfilSelecionado = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(perfilSelecionado))
            {
                // Se nada foi selecionado, mostra tudo
                AtualizarListView(listaCompleta);
            }
            else
            {
                // Filtra por perfil (campo pessoa.Regime)
                var filtrados = listaCompleta
                    .Where(p => p.PerfilPsicologico == perfilSelecionado)
                    .ToList();

                AtualizarListView(filtrados);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListaDePrisoneiros_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
