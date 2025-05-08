namespace FatecPoo
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNprisioneiro = new Label();
            label1 = new Label();
            pnlPrisioneiro = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            lblCelaDis = new Label();
            panel2 = new Panel();
            label4 = new Label();
            lblRelatorioPen = new Label();
            pnlPrisioneiro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNprisioneiro
            // 
            lblNprisioneiro.AutoSize = true;
            lblNprisioneiro.Font = new Font("Segoe UI", 18F);
            lblNprisioneiro.Location = new Point(165, 63);
            lblNprisioneiro.Name = "lblNprisioneiro";
            lblNprisioneiro.Size = new Size(27, 32);
            lblNprisioneiro.TabIndex = 0;
            lblNprisioneiro.Text = "0";
            lblNprisioneiro.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(46, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "Prisioneiros";
            label1.Click += label1_Click_1;
            // 
            // pnlPrisioneiro
            // 
            pnlPrisioneiro.BackColor = SystemColors.ButtonShadow;
            pnlPrisioneiro.Controls.Add(label1);
            pnlPrisioneiro.Controls.Add(lblNprisioneiro);
            pnlPrisioneiro.Location = new Point(45, 58);
            pnlPrisioneiro.Name = "pnlPrisioneiro";
            pnlPrisioneiro.Size = new Size(200, 100);
            pnlPrisioneiro.TabIndex = 3;
            pnlPrisioneiro.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCelaDis);
            panel1.Location = new Point(279, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(21, 11);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 2;
            label2.Text = "Celas disponiveis";
            label2.Click += label2_Click;
            // 
            // lblCelaDis
            // 
            lblCelaDis.AutoSize = true;
            lblCelaDis.Font = new Font("Segoe UI", 18F);
            lblCelaDis.Location = new Point(165, 63);
            lblCelaDis.Name = "lblCelaDis";
            lblCelaDis.Size = new Size(27, 32);
            lblCelaDis.TabIndex = 0;
            lblCelaDis.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblRelatorioPen);
            panel2.Location = new Point(527, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 2;
            label4.Text = "Relatorio pendente";
            // 
            // lblRelatorioPen
            // 
            lblRelatorioPen.AutoSize = true;
            lblRelatorioPen.Font = new Font("Segoe UI", 18F);
            lblRelatorioPen.Location = new Point(165, 63);
            lblRelatorioPen.Name = "lblRelatorioPen";
            lblRelatorioPen.Size = new Size(27, 32);
            lblRelatorioPen.TabIndex = 0;
            lblRelatorioPen.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPrisioneiro);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            pnlPrisioneiro.ResumeLayout(false);
            pnlPrisioneiro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label1;
        private Label lblNprisioneiro;
        private Label label1;
        private Panel pnlPrisioneiro;
        private Panel panel1;
        private Label label2;
        private Label lblCelaDis;
        private Panel panel2;
        private Label label4;
        private Label lblRelatorioPen;
    }
}