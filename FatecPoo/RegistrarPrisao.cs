using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void SalvarNoBanco(string nome, string endereco, string nivelseguranca)
        {
            string conexao = "server=localhost;database=prisionadm;uid=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO prisao (nome, endereco, nivelseguranca) VALUES (@nome, @endereco, @nivel)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
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

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            string nome = textNomePrisao.Text;
            string endereco = textEndereçoPrisao.Text;  // <-- Aqui pode deixar o nome do textbox como está, mas a variável C# mudou para "endereco"

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(endereco))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            string nivelseguranca = "";
            if (rbMinima.Checked)
            {
                nivelseguranca = "Minima";
            }
            else if (rbMedia.Checked)
            {
                nivelseguranca = "Media";
            }
            else if (rbMaxima.Checked)
            {
                nivelseguranca = "Maxima";
            }
            else
            {
                MessageBox.Show("Selecione um nível de segurança.");
                return;
            }

            SalvarNoBanco(nome, endereco, nivelseguranca);
        }

        // Demais eventos que você ainda tem aí (pode deixar como estão, ou remover se quiser)
    }
}
