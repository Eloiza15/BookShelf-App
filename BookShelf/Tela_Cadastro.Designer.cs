namespace BookShelf
{

    partial class Tela_Cadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            Panel_cadastro = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            txt_senha = new TextBox();
            txt_email = new TextBox();
            txt_login = new TextBox();
            txt_nome = new TextBox();
            panel1.SuspendLayout();
            Panel_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(32, 774);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 39);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 10);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 1;
            label5.Text = "Ja possui conta?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(200, 10);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 17);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Panel_cadastro
            // 
            Panel_cadastro.Controls.Add(pictureBox1);
            Panel_cadastro.Controls.Add(groupBox1);
            Panel_cadastro.Dock = DockStyle.Fill;
            Panel_cadastro.Location = new Point(0, 0);
            Panel_cadastro.Name = "Panel_cadastro";
            Panel_cadastro.Size = new Size(595, 320);
            Panel_cadastro.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5f9d8322_69d6_45f7_ad15_8ae4619609a7;
            pictureBox1.Location = new Point(321, 53);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_login);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Location = new Point(33, 18);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(267, 292);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(92, 214);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(80, 25);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_cad_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(linkLabel2);
            panel3.Location = new Point(0, 252);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 39);
            panel3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 1;
            label1.Text = "Ja possui conta?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(161, 10);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(42, 17);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Logar";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 160);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 7;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 75);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 5;
            label2.Text = "Login:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 33);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 4;
            label6.Text = "Nome:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(57, 179);
            txt_senha.Margin = new Padding(2);
            txt_senha.MaxLength = 8;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(158, 25);
            txt_senha.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(58, 137);
            txt_email.Margin = new Padding(2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(158, 25);
            txt_email.TabIndex = 2;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(57, 95);
            txt_login.Margin = new Padding(2);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(158, 25);
            txt_login.TabIndex = 1;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(57, 52);
            txt_nome.Margin = new Padding(2);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(158, 25);
            txt_nome.TabIndex = 0;
            // 
            // Tela_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 254, 255);
            Controls.Add(Panel_cadastro);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Tela_Cadastro";
            Size = new Size(595, 320);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Panel_cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label5;
        private Panel Panel_cadastro;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private LinkLabel linkLabel2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txt_senha;
        private TextBox txt_email;
        private TextBox txt_login;
        private TextBox txt_nome;
    }
}
