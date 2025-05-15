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
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            lblPeniCela = new Label();
            panel6 = new Panel();
            lblRegPrisioneiro = new Label();
            panel5 = new Panel();
            lblListPrisoneiro = new Label();
            label3 = new Label();
            pnlPrisioneiro.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lblNprisioneiro
            // 
            lblNprisioneiro.AutoSize = true;
            lblNprisioneiro.Font = new Font("Segoe UI", 27F);
            lblNprisioneiro.Location = new Point(165, 100);
            lblNprisioneiro.Name = "lblNprisioneiro";
            lblNprisioneiro.Size = new Size(39, 48);
            lblNprisioneiro.TabIndex = 0;
            lblNprisioneiro.Text = "0";
            lblNprisioneiro.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(80, 11);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 2;
            label1.Text = "Prisioneiros";
            label1.Click += label1_Click_1;
            // 
            // pnlPrisioneiro
            // 
            pnlPrisioneiro.BackColor = SystemColors.ButtonShadow;
            pnlPrisioneiro.Controls.Add(label1);
            pnlPrisioneiro.Controls.Add(lblNprisioneiro);
            pnlPrisioneiro.Location = new Point(33, 118);
            pnlPrisioneiro.Name = "pnlPrisioneiro";
            pnlPrisioneiro.Size = new Size(332, 185);
            pnlPrisioneiro.TabIndex = 3;
            pnlPrisioneiro.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCelaDis);
            panel1.Location = new Point(447, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 185);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(43, 11);
            label2.Name = "label2";
            label2.Size = new Size(244, 41);
            label2.TabIndex = 2;
            label2.Text = "Celas disponiveis";
            label2.Click += label2_Click;
            // 
            // lblCelaDis
            // 
            lblCelaDis.AutoSize = true;
            lblCelaDis.Font = new Font("Segoe UI", 27F);
            lblCelaDis.Location = new Point(141, 100);
            lblCelaDis.Name = "lblCelaDis";
            lblCelaDis.Size = new Size(39, 48);
            lblCelaDis.TabIndex = 0;
            lblCelaDis.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblRelatorioPen);
            panel2.Location = new Point(863, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 185);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F);
            label4.Location = new Point(27, 11);
            label4.Name = "label4";
            label4.Size = new Size(272, 41);
            label4.TabIndex = 2;
            label4.Text = "Relatorio pendente";
            // 
            // lblRelatorioPen
            // 
            lblRelatorioPen.AutoSize = true;
            lblRelatorioPen.Font = new Font("Segoe UI", 27F);
            lblRelatorioPen.Location = new Point(208, 100);
            lblRelatorioPen.Name = "lblRelatorioPen";
            lblRelatorioPen.Size = new Size(39, 48);
            lblRelatorioPen.TabIndex = 0;
            lblRelatorioPen.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1903, 52);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(54, 397);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 428);
            panel4.TabIndex = 7;
            panel4.Paint += panel4_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(lblPeniCela);
            panel7.Location = new Point(39, 280);
            panel7.Name = "panel7";
            panel7.Size = new Size(374, 41);
            panel7.TabIndex = 2;
            // 
            // lblPeniCela
            // 
            lblPeniCela.AutoSize = true;
            lblPeniCela.Font = new Font("Segoe UI", 14F);
            lblPeniCela.Location = new Point(165, 8);
            lblPeniCela.Name = "lblPeniCela";
            lblPeniCela.Size = new Size(186, 25);
            lblPeniCela.TabIndex = 8;
            lblPeniCela.Text = "Penitenciaria e Celas";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(lblRegPrisioneiro);
            panel6.Location = new Point(39, 200);
            panel6.Name = "panel6";
            panel6.Size = new Size(374, 41);
            panel6.TabIndex = 2;
            // 
            // lblRegPrisioneiro
            // 
            lblRegPrisioneiro.AutoSize = true;
            lblRegPrisioneiro.Font = new Font("Segoe UI", 14F);
            lblRegPrisioneiro.Location = new Point(180, 8);
            lblRegPrisioneiro.Name = "lblRegPrisioneiro";
            lblRegPrisioneiro.Size = new Size(182, 25);
            lblRegPrisioneiro.TabIndex = 1;
            lblRegPrisioneiro.Text = "Registrar prisioneiro";
            lblRegPrisioneiro.Click += lblRegPrisioneiro_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(lblListPrisoneiro);
            panel5.Location = new Point(39, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(374, 41);
            panel5.TabIndex = 1;
            // 
            // lblListPrisoneiro
            // 
            lblListPrisoneiro.AutoSize = true;
            lblListPrisoneiro.Font = new Font("Segoe UI", 14F);
            lblListPrisoneiro.Location = new Point(180, 8);
            lblListPrisoneiro.Name = "lblListPrisoneiro";
            lblListPrisoneiro.Size = new Size(172, 25);
            lblListPrisoneiro.TabIndex = 0;
            lblListPrisoneiro.Text = "Lista de prisioneiro";
            lblListPrisoneiro.Click += lblListPrisoneiro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(25, 22);
            label3.Name = "label3";
            label3.Size = new Size(218, 41);
            label3.TabIndex = 0;
            label3.Text = "Acessos rápido";
            label3.Click += label3_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPrisioneiro);
            Name = "TelaInicial";
            Text = "Form2";
            Load += Form2_Load;
            pnlPrisioneiro.ResumeLayout(false);
            pnlPrisioneiro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Panel panel7;
        private Label lblPeniCela;
        private Panel panel6;
        private Label lblRegPrisioneiro;
        private Label lblListPrisoneiro;
    }
}