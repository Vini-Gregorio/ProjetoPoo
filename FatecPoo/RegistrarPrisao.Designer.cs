namespace FatecPoo
{
    partial class RegistrarPrisao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSalvar = new Label();
            label3 = new Label();
            rbMaxima = new RadioButton();
            rbMedia = new RadioButton();
            label2 = new Label();
            rbMinima = new RadioButton();
            label1 = new Label();
            textEndereçoPrisao = new TextBox();
            textNomePrisao = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSalvar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rbMaxima);
            panel1.Controls.Add(rbMedia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rbMinima);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textEndereçoPrisao);
            panel1.Controls.Add(textNomePrisao);
            panel1.Location = new Point(71, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 487);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblSalvar
            // 
            lblSalvar.AutoSize = true;
            lblSalvar.BackColor = SystemColors.ActiveCaptionText;
            lblSalvar.Font = new Font("Segoe UI", 20F);
            lblSalvar.ForeColor = SystemColors.ButtonFace;
            lblSalvar.Location = new Point(133, 405);
            lblSalvar.Name = "lblSalvar";
            lblSalvar.Size = new Size(116, 37);
            lblSalvar.TabIndex = 11;
            lblSalvar.Text = "  Salvar  ";
            lblSalvar.Click += lblSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 147);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Endereço da prisão";
            label3.Click += label3_Click;
            // 
            // rbMaxima
            // 
            rbMaxima.AutoSize = true;
            rbMaxima.Location = new Point(176, 275);
            rbMaxima.Name = "rbMaxima";
            rbMaxima.Size = new Size(68, 19);
            rbMaxima.TabIndex = 7;
            rbMaxima.TabStop = true;
            rbMaxima.Text = "Máxima";
            rbMaxima.UseVisualStyleBackColor = true;
            rbMaxima.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Location = new Point(112, 275);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(58, 19);
            rbMedia.TabIndex = 6;
            rbMedia.TabStop = true;
            rbMedia.Text = "Média";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 247);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Nível de segurança";
            // 
            // rbMinima
            // 
            rbMinima.AutoSize = true;
            rbMinima.Location = new Point(40, 275);
            rbMinima.Name = "rbMinima";
            rbMinima.Size = new Size(66, 19);
            rbMinima.TabIndex = 4;
            rbMinima.TabStop = true;
            rbMinima.Text = "Mínima";
            rbMinima.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome da prisão";
            label1.Click += label1_Click;
            // 
            // textEndereçoPrisao
            // 
            textEndereçoPrisao.Location = new Point(43, 179);
            textEndereçoPrisao.Multiline = true;
            textEndereçoPrisao.Name = "textEndereçoPrisao";
            textEndereçoPrisao.Size = new Size(181, 33);
            textEndereçoPrisao.TabIndex = 1;
            // 
            // textNomePrisao
            // 
            textNomePrisao.Location = new Point(43, 73);
            textNomePrisao.Multiline = true;
            textNomePrisao.Name = "textNomePrisao";
            textNomePrisao.Size = new Size(181, 33);
            textNomePrisao.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(416, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 487);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(19, 27);
            label5.Name = "label5";
            label5.Size = new Size(223, 37);
            label5.TabIndex = 11;
            label5.Text = "Prisões existentes";
            label5.Click += label5_Click;
            // 
            // RegistrarPrisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrarPrisao";
            Text = "RegistrarPrisao";
            Load += RegistrarPrisao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textNomePrisao;
        private TextBox textEndereçoPrisao;
        private Label label1;
        private RadioButton rbMinima;
        private RadioButton rbMaxima;
        private RadioButton rbMedia;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label lblSalvar;

        private void RegistrarPrisao_Load(object sender, EventArgs e)
        {
            // Evento de load - pode deixar vazio ou implementar depois
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Evento click do label5 - pode deixar vazio ou implementar depois
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento click do label1 - pode deixar vazio ou implementar depois
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Evento CheckedChanged - pode deixar vazio ou implementar depois
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento click do label3 - pode deixar vazio ou implementar depois
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Evento de pintura do panel - pode deixar vazio ou implementar depois
        }
    }
}
