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
            txtEmail = new TextBox();
            labelNome = new Label();
            labelNascimento = new Label();
            labelEmail = new Label();
            btnCriar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            Listar = new Button();
            listDetentos = new ListBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(134, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(61, 157);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(134, 23);
            txtNascimento.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(61, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(61, 56);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Location = new Point(61, 127);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(71, 15);
            labelNascimento.TabIndex = 4;
            labelNascimento.Text = "Nascimento";
            labelNascimento.Click += labelNascimento_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(61, 202);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(228, 52);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(308, 249);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(120, 23);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(464, 249);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(125, 23);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Listar
            // 
            Listar.Location = new Point(634, 249);
            Listar.Name = "Listar";
            Listar.Size = new Size(122, 23);
            Listar.TabIndex = 9;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click;
            // 
            // listDetentos
            // 
            listDetentos.FormattingEnabled = true;
            listDetentos.ItemHeight = 15;
            listDetentos.Location = new Point(332, 33);
            listDetentos.Name = "listDetentos";
            listDetentos.Size = new Size(380, 184);
            listDetentos.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(listDetentos);
            Controls.Add(Listar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCriar);
            Controls.Add(labelEmail);
            Controls.Add(labelNascimento);
            Controls.Add(labelNome);
            Controls.Add(txtEmail);
            Controls.Add(txtNascimento);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtNascimento;
        private TextBox txtEmail;
        private Label labelNome;
        private Label labelNascimento;
        private Label labelEmail;
        private Button btnCriar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button Listar;
        private ListBox listDetentos;
    }
}
