namespace BookShelf
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            btn_cad = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_senha = new TextBox();
            label2 = new Label();
            txt_login = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 254, 255);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 320);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(btn_cad);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_login);
            groupBox1.Location = new Point(33, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 291);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 40);
            panel2.TabIndex = 4;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(74, 22);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(129, 17);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Esqueci minha senha";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(148, 5);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastre-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 5);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 0;
            label3.Text = "Não possui conta?";
            // 
            // btn_cad
            // 
            btn_cad.BackColor = Color.FromArgb(192, 0, 0);
            btn_cad.FlatStyle = FlatStyle.Flat;
            btn_cad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cad.ForeColor = SystemColors.ControlLight;
            btn_cad.Location = new Point(97, 210);
            btn_cad.Name = "btn_cad";
            btn_cad.Size = new Size(70, 25);
            btn_cad.TabIndex = 6;
            btn_cad.Text = "Logar";
            btn_cad.UseVisualStyleBackColor = false;
            btn_cad.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 96);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(52, 179);
            txt_senha.MaxLength = 8;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(158, 25);
            txt_senha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 159);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(52, 117);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(158, 25);
            txt_login.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5f9d8322_69d6_45f7_ad15_8ae4619609a7;
            pictureBox2.Location = new Point(321, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 222);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Tela_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Tela_Login";
            Size = new Size(595, 320);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txt_senha;
        private TextBox txt_login;
        private Panel panel2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button btn_cad;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel2;
    }
}
