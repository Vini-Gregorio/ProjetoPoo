namespace FatecPoo
{
    partial class CadastrarDetento
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtDataDeEntrada = new TextBox();
            txtDataDeSaida = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(47, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(134, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 115);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Cela";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 181);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 4;
            label3.Text = "DataDeNascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 44);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 5;
            label4.Text = "DataDeEntrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 115);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 6;
            label5.Text = "DataDeSaida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 8;
            // 
            // txtDataDeEntrada
            // 
            txtDataDeEntrada.Location = new Point(295, 78);
            txtDataDeEntrada.Name = "txtDataDeEntrada";
            txtDataDeEntrada.Size = new Size(115, 23);
            txtDataDeEntrada.TabIndex = 9;
            // 
            // txtDataDeSaida
            // 
            txtDataDeSaida.Location = new Point(295, 141);
            txtDataDeSaida.Name = "txtDataDeSaida";
            txtDataDeSaida.Size = new Size(115, 23);
            txtDataDeSaida.TabIndex = 10;
            // 
            // CadastrarDetento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDataDeSaida);
            Controls.Add(txtDataDeEntrada);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "CadastrarDetento";
            Text = "CadastrarDetento";
            Load += CadastrarDetento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtDataDeEntrada;
        private TextBox txtDataDeSaida;
    }
}