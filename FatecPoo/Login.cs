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
        private void AbrirTela(Form Tela)
        {
            Tela.Show(); // ou ShowDialog() se quiser que a tela anterior fique travada
        }
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

     

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string con = "server =127.0.0.1; user =root; database =prisionadm; password=";
                MySqlConnection mySqlConnection = new MySqlConnection(con);

                string username = txtNome.Text.ToString();
                string password = txtSenha.Text.ToString();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Campo vazio");
                }
                else
                {
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from usuario", mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("nome")) && password.Equals(reader.GetString("senha")))
                        {
                            MessageBox.Show("--->>> Entrando -->>>");
                            AbrirTela(new TelaInicial());
                        }
                        else
                        {
                            MessageBox.Show("Login inválido :/");
                        }
                    }
                    mySqlConnection.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
