using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FichaPrisao : Form
    {
        private Prisao1 prisao;

        public FichaPrisao(Prisao1 p)
        {
            InitializeComponent();
            prisao = p;
            ExibirDados();
        }

        private void ExibirDados()
        {
            lblId.Text = prisao.Id.ToString();
            lblNome.Text = prisao.Prisao;
            lblNivelSeguranca.Text = prisao.NivelSegurança;
            lblEndereco.Text = prisao.Endereco;
        }
    }
}