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
        public TelaInicial()
        {
            InitializeComponent();

            string Nprisioneiro = "100";
            lblNprisioneiro.Text = $" {Nprisioneiro}";
            string RelatorioPen = "50";
            lblRelatorioPen.Text = $"{RelatorioPen}";
            string CelaDis = "40";
            lblCelaDis.Text = $"{CelaDis}";

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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
