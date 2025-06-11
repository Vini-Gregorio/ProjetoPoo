using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FatecPoo
{

    public partial class RegistrarPrisao : Form
    {
        private void SalvarNoBanco(string nome, string endereço, string nivelseguranca)
        {
            string conexao = "server=localhost;database=prisionadm;uid=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO prisao (nome, endereço, nivelseguranca) VALUES (@nome, @endereço, @nivel)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@endereço", endereço);
                        cmd.Parameters.AddWithValue("@nivel", nivelseguranca);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }
        public RegistrarPrisao()
        {
            InitializeComponent();
        }

        private void RegistrarPrisao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            string nome = textNomePrisao.Text;
            string endereço = textEndereçoPrisao.Text;
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereço))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            string nivelsegurança = "";
            if (rbMinima.Checked)
            {
                nivelsegurança = "Minima";
            }
            else if (rbMedia.Checked)
            {
                nivelsegurança = "Media";
            }
            else if (rbMaxima.Checked)
            {
                nivelsegurança = "Maxima";
            }
            else
            {
                MessageBox.Show("Selecione um nível de segurança.");
                return;
            }
            SalvarNoBanco(nome, endereço, nivelsegurança);
        }
    }
}
