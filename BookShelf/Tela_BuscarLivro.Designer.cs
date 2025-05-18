namespace BookShelf
{
    partial class Tela_BuscarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_BuscarLivro));
            panelSuperior = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelBuscaLivro = new Panel();
            lblTituloTela = new Label();
            btnEstante = new Button();
            btnSalvar = new Button();
            picLogo = new PictureBox();
            lblCategoria = new Label();
            lblEditora = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            lblCapa = new Label();
            picCapa = new PictureBox();
            label6 = new Label();
            lblCategoriaa = new Label();
            lblEditoraa = new Label();
            lblAutorr = new Label();
            lblTituloo = new Label();
            txtBuscarLivro = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBuscaLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCapa).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(192, 0, 0);
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(650, 36);
            panelSuperior.TabIndex = 0;
            panelSuperior.MouseDown += panelSuperior_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(593, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(623, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelBuscaLivro
            // 
            panelBuscaLivro.BackColor = Color.FromArgb(224, 254, 255);
            panelBuscaLivro.Controls.Add(lblTituloTela);
            panelBuscaLivro.Controls.Add(btnEstante);
            panelBuscaLivro.Controls.Add(btnSalvar);
            panelBuscaLivro.Controls.Add(picLogo);
            panelBuscaLivro.Controls.Add(lblCategoria);
            panelBuscaLivro.Controls.Add(lblEditora);
            panelBuscaLivro.Controls.Add(lblAutor);
            panelBuscaLivro.Controls.Add(lblTitulo);
            panelBuscaLivro.Controls.Add(lblCapa);
            panelBuscaLivro.Controls.Add(picCapa);
            panelBuscaLivro.Controls.Add(label6);
            panelBuscaLivro.Controls.Add(lblCategoriaa);
            panelBuscaLivro.Controls.Add(lblEditoraa);
            panelBuscaLivro.Controls.Add(lblAutorr);
            panelBuscaLivro.Controls.Add(lblTituloo);
            panelBuscaLivro.Controls.Add(txtBuscarLivro);
            panelBuscaLivro.Controls.Add(label1);
            panelBuscaLivro.Controls.Add(btnBuscar);
            panelBuscaLivro.Dock = DockStyle.Fill;
            panelBuscaLivro.Location = new Point(0, 36);
            panelBuscaLivro.Name = "panelBuscaLivro";
            panelBuscaLivro.Size = new Size(650, 474);
            panelBuscaLivro.TabIndex = 1;
            // 
            // lblTituloTela
            // 
            lblTituloTela.AutoSize = true;
            lblTituloTela.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTela.Location = new Point(257, 17);
            lblTituloTela.Name = "lblTituloTela";
            lblTituloTela.Size = new Size(129, 25);
            lblTituloTela.TabIndex = 19;
            lblTituloTela.Text = "Buscar Livros";
            // 
            // btnEstante
            // 
            btnEstante.BackColor = Color.FromArgb(192, 0, 0);
            btnEstante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstante.ForeColor = Color.White;
            btnEstante.Location = new Point(513, 411);
            btnEstante.Name = "btnEstante";
            btnEstante.Size = new Size(125, 51);
            btnEstante.TabIndex = 18;
            btnEstante.Text = "Minha Estante Pessoal";
            btnEstante.UseVisualStyleBackColor = false;
            btnEstante.Click += btnEstante_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Indigo;
            btnSalvar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(249, 423);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(137, 26);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar na Estante";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources._5f9d8322_69d6_45f7_ad15_8ae4619609a7;
            picLogo.Location = new Point(571, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(79, 83);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(139, 349);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(81, 17);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "<categoria>";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(139, 304);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(68, 17);
            lblEditora.TabIndex = 12;
            lblEditora.Text = "<editora>";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(139, 261);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(57, 17);
            lblAutor.TabIndex = 11;
            lblAutor.Text = "<autor>";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(139, 219);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(55, 17);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "<titulo>";
            // 
            // lblCapa
            // 
            lblCapa.AutoSize = true;
            lblCapa.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapa.Location = new Point(462, 156);
            lblCapa.Name = "lblCapa";
            lblCapa.Size = new Size(48, 18);
            lblCapa.TabIndex = 9;
            lblCapa.Text = "Capa:";
            // 
            // picCapa
            // 
            picCapa.Image = Properties.Resources.ChatGPT_Image_18_de_mai__de_2025__12_17_53;
            picCapa.Location = new Point(419, 186);
            picCapa.Name = "picCapa";
            picCapa.Size = new Size(127, 204);
            picCapa.SizeMode = PictureBoxSizeMode.StretchImage;
            picCapa.TabIndex = 8;
            picCapa.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 156);
            label6.Name = "label6";
            label6.Size = new Size(203, 23);
            label6.TabIndex = 7;
            label6.Text = "Informações do Livro:";
            // 
            // lblCategoriaa
            // 
            lblCategoriaa.AutoSize = true;
            lblCategoriaa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoriaa.Location = new Point(45, 351);
            lblCategoriaa.Name = "lblCategoriaa";
            lblCategoriaa.Size = new Size(64, 15);
            lblCategoriaa.TabIndex = 6;
            lblCategoriaa.Text = "Categoria:";
            // 
            // lblEditoraa
            // 
            lblEditoraa.AutoSize = true;
            lblEditoraa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditoraa.Location = new Point(45, 306);
            lblEditoraa.Name = "lblEditoraa";
            lblEditoraa.Size = new Size(49, 15);
            lblEditoraa.TabIndex = 5;
            lblEditoraa.Text = "Editora:";
            // 
            // lblAutorr
            // 
            lblAutorr.AutoSize = true;
            lblAutorr.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutorr.Location = new Point(45, 263);
            lblAutorr.Name = "lblAutorr";
            lblAutorr.Size = new Size(53, 15);
            lblAutorr.TabIndex = 4;
            lblAutorr.Text = "Autor(a):";
            // 
            // lblTituloo
            // 
            lblTituloo.AutoSize = true;
            lblTituloo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloo.Location = new Point(45, 221);
            lblTituloo.Name = "lblTituloo";
            lblTituloo.Size = new Size(40, 15);
            lblTituloo.TabIndex = 3;
            lblTituloo.Text = "Título:";
            // 
            // txtBuscarLivro
            // 
            txtBuscarLivro.Location = new Point(257, 73);
            txtBuscarLivro.Name = "txtBuscarLivro";
            txtBuscarLivro.Size = new Size(280, 25);
            txtBuscarLivro.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 75);
            label1.Name = "label1";
            label1.Size = new Size(197, 17);
            label1.TabIndex = 1;
            label1.Text = "Digite o livro que deseja buscar:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Indigo;
            btnBuscar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(462, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 26);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Tela_BuscarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 510);
            Controls.Add(panelBuscaLivro);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tela_BuscarLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_BuscarLivro";
            panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBuscaLivro.ResumeLayout(false);
            panelBuscaLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelBuscaLivro;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label lblCategoriaa;
        private Label lblEditoraa;
        private Label lblAutorr;
        private Label lblTituloo;
        private TextBox txtBuscarLivro;
        private Label label1;
        private Button btnBuscar;
        private Label lblCapa;
        private PictureBox picCapa;
        private Label lblCategoria;
        private Label lblEditora;
        private Label lblAutor;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Button btnSalvar;
        private Button btnEstante;
        private Label lblTituloTela;
    }
}