namespace FatecPoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtNascimento = new TextBox();
            labelNome = new Label();
            labelNascimento = new Label();
            btnCriar = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.WindowFrame;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(24, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(134, 16);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtNascimento
            // 
            txtNascimento.BackColor = SystemColors.WindowFrame;
            txtNascimento.BorderStyle = BorderStyle.None;
            txtNascimento.Location = new Point(24, 184);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(134, 16);
            txtNascimento.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(24, 47);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Location = new Point(24, 154);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(71, 15);
            labelNascimento.TabIndex = 4;
            labelNascimento.Text = "Nascimento";
            labelNascimento.Click += labelNascimento_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = SystemColors.ActiveCaptionText;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.ForeColor = SystemColors.ButtonShadow;
            btnCriar.Location = new Point(211, 239);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(120, 23);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(184, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 187);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(0, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 166);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(372, 283);
            Controls.Add(groupBox1);
            Controls.Add(btnCriar);
            Controls.Add(labelNascimento);
            Controls.Add(labelNome);
            Controls.Add(txtNascimento);
            Controls.Add(txtNome);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtNascimento;
        private Label labelNome;
        private Label labelNascimento;
        private Button btnCriar;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
