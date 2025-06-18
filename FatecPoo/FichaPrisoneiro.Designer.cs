using FatecPoo;
using Microsoft.VisualBasic.ApplicationServices;
namespace FatecPoo
{
    partial class FichaPrisoneiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaPrisoneiro));
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(32, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 134);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 25);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(163, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(184, 130);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Regime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(label4);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(373, 110);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(184, 130);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nivel de Perigo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(32, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 127);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FichaPrisoneiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(588, 688);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FichaPrisoneiro";
            Text = "FichaPrisoneiro";
            Load += FichaPrisoneiro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label3;
        private GroupBox groupBox4;
        private Label label4;
        private PictureBox pictureBox1;
    }
}