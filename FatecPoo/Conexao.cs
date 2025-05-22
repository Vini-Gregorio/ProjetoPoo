using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FatecPoo
{
    public class Conexao
    {

        private readonly string connectionString = "server=localhost;user=root;database=prisionadmin;password=";
        private MySqlConnection connection;

        public Conexao()
        {
            connection = new MySqlConnection(connectionString);
        }

        public bool AbrirConexao()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Logar erro, exibir se necessário
                Console.WriteLine("Erro de conexão: " + ex.Message);
                return false;
            }
        }

        public void FecharConexao()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection ObterConexao()
        {
            return connection;
        }
        /*EXEMPLOS DE UTILIZAÇÃO:
         * 
  
        
        var conexao = new Conexao();

if (conexao.AbrirConexao())
{
    var comando = new MySqlCommand("SELECT * FROM usuarios", conexao.ObterConexao());
    var reader = comando.ExecuteReader();

    while (reader.Read())
    {
        Console.WriteLine(reader["nome"].ToString());
    }

    reader.Close();
    conexao.FecharConexao();




}


        PARA LISTAR QUANTIDADE:

        using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SeuProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarTotalUsuarios();
        }

        private void MostrarTotalUsuarios()
        {
            Conexao conexao = new Conexao();

            if (conexao.AbrirConexao())
            {
                string query = "SELECT COUNT(*) FROM usuarios";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexao.ObterConexao());
                    int total = Convert.ToInt32(cmd.ExecuteScalar()); // Retorna um único valor

                    lblTotalUsuarios.Text = $"Total de usuários: {total}";
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
    }
}


        */
    }
}
    
