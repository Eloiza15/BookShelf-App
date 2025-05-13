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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastro));
            groupBox1 = new GroupBox();
            txt_nome = new TextBox();
            txt_login = new TextBox();
            txt_email = new TextBox();
            txt_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_login);
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Location = new Point(41, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(32, 66);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(305, 31);
            txt_nome.TabIndex = 0;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(32, 128);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(305, 31);
            txt_login.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(32, 190);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(305, 31);
            txt_email.TabIndex = 2;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(32, 252);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(305, 31);
            txt_senha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 162);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 224);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 7;
            label4.Text = "Senha:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 46);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(107, 298);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(231, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 9);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 1;
            label5.Text = "Ja possui conta?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(440, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Tela_Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 254, 255);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Tela_Cadastro";
            Size = new Size(850, 460);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_senha;
        private TextBox txt_email;
        private TextBox txt_login;
        private TextBox txt_nome;
        private Button button1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
