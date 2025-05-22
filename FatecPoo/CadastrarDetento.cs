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
    public partial class CadastrarDetento : Form
    {
        public CadastrarDetento()
        {
            InitializeComponent();
            string con = "server =127.0.0.1; user =root; database =prisionadm; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(con);
            try
            {
                mySqlConnection.Open();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DataDeEntrada(object sender, EventArgs e)
        {

        }

        private void CadastrarDetento_Load(object sender, EventArgs e)
        {

        }

    }
}
