using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Windows.Forms;

namespace FatecPoo
{
    partial class FichaPrisao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNivelSeguranca;
        private System.Windows.Forms.Label lblEndereco;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblId = new Label();
            lblNome = new Label();
            lblNivelSeguranca = new Label();
            lblEndereco = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(109, 92);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(109, 122);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(94, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome da Prisão:";
            // 
            // lblNivelSeguranca
            // 
            lblNivelSeguranca.AutoSize = true;
            lblNivelSeguranca.Location = new Point(109, 152);
            lblNivelSeguranca.Name = "lblNivelSeguranca";
            lblNivelSeguranca.Size = new Size(111, 15);
            lblNivelSeguranca.TabIndex = 2;
            lblNivelSeguranca.Text = "Nível de Segurança:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(109, 182);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // FichaPrisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 321);
            Controls.Add(lblId);
            Controls.Add(lblNome);
            Controls.Add(lblNivelSeguranca);
            Controls.Add(lblEndereco);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FichaPrisao";
            Text = "Ficha da Prisão";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
