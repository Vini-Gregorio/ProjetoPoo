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
    public partial class TelaInicial : Form
    {
        private void AbrirTela(Form Tela)
        {
            Tela.Show(); // ou ShowDialog() se quiser que a tela anterior fique travada
        }
        public TelaInicial()
        {

            InitializeComponent();

     
            MostrarTotalDetentos();
            string RelatorioPen = "50";
            lblRelatorioPen.Text = $"{RelatorioPen}";
            string CelaDis = "40";
            lblCelaDis.Text = $"{CelaDis}";
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

                    lblNprisioneiro.Text = $"Total de usuários: {total}";
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

            CentralizarLabel(lblNprisioneiro, pnlPrisioneiro);
            CentralizarLabel(lblCelaDis, panel1);
            CentralizarLabel(lblRelatorioPen, panel2);
            CentralizarLabel(lblListPrisoneiro, panel5);
            CentralizarLabel(lblRegPrisioneiro, panel6);
            CentralizarLabel(lblPeniCela, panel7);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        }

        private void lblRegPrisioneiro_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastrarDetento());
        }
    }
}
