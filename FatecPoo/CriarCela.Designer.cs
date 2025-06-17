namespace FatecPoo
{
    partial class CriarCela
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
            panel1 = new Panel();
            textEndereçoPrisao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textEndereçoPrisao);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(126, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 406);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textEndereçoPrisao
            // 
            textEndereçoPrisao.Location = new Point(47, 251);
            textEndereçoPrisao.Multiline = true;
            textEndereçoPrisao.Name = "textEndereçoPrisao";
            textEndereçoPrisao.Size = new Size(181, 33);
            textEndereçoPrisao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 220);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacidade da sela";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 65);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Pertence a prisão";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 33);
            textBox1.TabIndex = 4;
            // 
            // CriarCela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 609);
            Controls.Add(panel1);
            Name = "CriarCela";
            Text = "CriarSela";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textEndereçoPrisao;
        private TextBox textBox1;
        private Label label2;
    }
}