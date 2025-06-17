using FatecPoo;

namespace FatecPoo;

public partial class ListaDePrisoneiros : Form
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

        // **Aqui adiciona as colunas**
        listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
        listView1.Columns.Add("Nome", 300, HorizontalAlignment.Left);
        listView1.Columns.Add("Idade", 174, HorizontalAlignment.Center);
        listView1.Columns.Add("Nascimento", 174, HorizontalAlignment.Center);
        listView1.Columns.Add("Data de Registro", 174, HorizontalAlignment.Center);
    }



    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        buttonPrisonerRegister = new Button();
        textBox1 = new TextBox();
        comboBox1 = new ComboBox();
        comboBox3 = new ComboBox();
        label1 = new Label();
        button1 = new Button();
        contextMenuStrip1 = new ContextMenuStrip(components);
        comboBox2 = new ComboBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.Location = new Point(12, 131);
        listView1.Name = "listView1";
        listView1.Size = new Size(926, 286);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        listView1.DoubleClick += listView1_DoubleClick;
        // 
        // buttonPrisonerRegister
        // 
        buttonPrisonerRegister.Location = new Point(484, 37);
        buttonPrisonerRegister.Name = "buttonPrisonerRegister";
        buttonPrisonerRegister.Size = new Size(307, 23);
        buttonPrisonerRegister.TabIndex = 2;
        buttonPrisonerRegister.Text = "Registrar Prisoneiro";
        buttonPrisonerRegister.UseVisualStyleBackColor = true;
        buttonPrisonerRegister.Click += buttonPrisonerRegister_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 91);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(392, 23);
        textBox1.TabIndex = 5;
        textBox1.Text = "Pesquisar...";
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Aberto", "Semiaberto", "Fechado" });
        comboBox1.Location = new Point(484, 91);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(152, 23);
        comboBox1.TabIndex = 6;
        comboBox1.Text = "Filtrar por regime";
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Items.AddRange(new object[] { "Baixo", "Médio", "Alto" });
        comboBox3.Location = new Point(657, 91);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(134, 23);
        comboBox3.TabIndex = 8;
        comboBox3.Text = "Nível de perigo";
        comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 37);
        label1.Name = "label1";
        label1.Size = new Size(253, 37);
        label1.TabIndex = 10;
        label1.Text = "Lista de Prisoneiros";
        // 
        // button1
        // 
        button1.Location = new Point(811, 37);
        button1.Name = "button1";
        button1.Size = new Size(128, 23);
        button1.TabIndex = 11;
        button1.Text = "Comandos";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        contextMenuStrip1.Opening += contextMenuStrip1_Opening;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Items.AddRange(new object[] { "Perfil Psicológico Estável", "Perfil com Riscos Moderados", "Perfil com Alto Grau de Instabilidade" });
        comboBox2.Location = new Point(810, 91);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(129, 23);
        comboBox2.TabIndex = 12;
        comboBox2.Text = "Perfil";
        comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(484, 73);
        label2.Name = "label2";
        label2.Size = new Size(101, 15);
        label2.TabIndex = 13;
        label2.Text = "Filtrar por Regime";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(657, 73);
        label3.Name = "label3";
        label3.Size = new Size(102, 15);
        label3.TabIndex = 14;
        label3.Text = "Filtrar por ameaça";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(810, 73);
        label4.Name = "label4";
        label4.Size = new Size(88, 15);
        label4.TabIndex = 15;
        label4.Text = "Filtrar por perfil";
        // 
        // ListaDePrisoneiros
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1018, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(comboBox2);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(comboBox3);
        Controls.Add(comboBox1);
        Controls.Add(textBox1);
        Controls.Add(buttonPrisonerRegister);
        Controls.Add(listView1);
        Name = "ListaDePrisoneiros";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListView listView1;
    private Button buttonPrisonerRegister;
    private TextBox textBox1;
    private ComboBox comboBox1;
    private ComboBox comboBox3;
    private Label label1;
    private ColumnHeader columnHeader1;
    private Button button1;
    private ContextMenuStrip contextMenuStrip1;
    private ComboBox comboBox2;
    private Label label2;
    private Label label3;
    private Label label4;
}
