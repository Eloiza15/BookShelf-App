namespace BookShelf
{
    partial class Tela_ListaLivros
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
            btnVoltarBuscaLivros = new Button();
            txtCategoria = new TextBox();
            txtEditora = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            lblCategoria = new Label();
            lblEditora = new Label();
            lblAutor = new Label();
            lblTituloLivro = new Label();
            btnEditar = new Button();
            btn_Excluir = new Button();
            dtgListarLivros = new DataGridView();
            ptbLogo = new PictureBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListarLivros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 254, 255);
            panel1.Controls.Add(btnVoltarBuscaLivros);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtEditora);
            panel1.Controls.Add(txtAutor);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblEditora);
            panel1.Controls.Add(lblAutor);
            panel1.Controls.Add(lblTituloLivro);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btn_Excluir);
            panel1.Controls.Add(dtgListarLivros);
            panel1.Controls.Add(ptbLogo);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 418);
            panel1.TabIndex = 0;
            // 
            // btnVoltarBuscaLivros
            // 
            btnVoltarBuscaLivros.BackColor = Color.FromArgb(192, 0, 0);
            btnVoltarBuscaLivros.FlatStyle = FlatStyle.Flat;
            btnVoltarBuscaLivros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarBuscaLivros.ForeColor = SystemColors.ControlLight;
            btnVoltarBuscaLivros.Location = new Point(21, 16);
            btnVoltarBuscaLivros.Name = "btnVoltarBuscaLivros";
            btnVoltarBuscaLivros.Size = new Size(58, 22);
            btnVoltarBuscaLivros.TabIndex = 17;
            btnVoltarBuscaLivros.Text = "Voltar";
            btnVoltarBuscaLivros.UseVisualStyleBackColor = false;
            btnVoltarBuscaLivros.Click += btnVoltarBuscaLivros_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(416, 306);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(189, 23);
            txtCategoria.TabIndex = 16;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(416, 270);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(190, 23);
            txtEditora.TabIndex = 15;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(115, 306);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(190, 23);
            txtAutor.TabIndex = 14;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(115, 270);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(190, 23);
            txtTitulo.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(330, 306);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 21);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditora.Location = new Point(348, 270);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(62, 21);
            lblEditora.TabIndex = 11;
            lblEditora.Text = "Editora:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(21, 306);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(70, 21);
            lblAutor.TabIndex = 10;
            lblAutor.Text = "Autor(a):";
            // 
            // lblTituloLivro
            // 
            lblTituloLivro.AutoSize = true;
            lblTituloLivro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloLivro.Location = new Point(39, 270);
            lblTituloLivro.Name = "lblTituloLivro";
            lblTituloLivro.Size = new Size(52, 21);
            lblTituloLivro.TabIndex = 9;
            lblTituloLivro.Text = "Titulo:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Indigo;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlLight;
            btnEditar.Location = new Point(188, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(70, 22);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.Indigo;
            btn_Excluir.FlatStyle = FlatStyle.Flat;
            btn_Excluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Excluir.ForeColor = SystemColors.ControlLight;
            btn_Excluir.Location = new Point(390, 370);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(70, 22);
            btn_Excluir.TabIndex = 7;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // dtgListarLivros
            // 
            dtgListarLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListarLivros.Location = new Point(21, 79);
            dtgListarLivros.Name = "dtgListarLivros";
            dtgListarLivros.RowHeadersVisible = false;
            dtgListarLivros.Size = new Size(609, 169);
            dtgListarLivros.TabIndex = 2;
            dtgListarLivros.CellDoubleClick += dtgListarLivros_CellDoubleClick;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources._5f9d8322_69d6_45f7_ad15_8ae4619609a7;
            ptbLogo.Location = new Point(571, 0);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(79, 73);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 1;
            ptbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(217, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Minha Estante Pessoal";
            // 
            // Tela_ListaLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Tela_ListaLivros";
            Size = new Size(650, 418);
            Load += Tela_ListaLivros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListarLivros).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private DataGridView dtgListarLivros;
        private PictureBox ptbLogo;
        private Button btn_Excluir;
        private Button btnEditar;
        private Label lblCategoria;
        private Label lblEditora;
        private Label lblAutor;
        private Label lblTituloLivro;
        private TextBox txtCategoria;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Button btnVoltarBuscaLivros;
    }
}
