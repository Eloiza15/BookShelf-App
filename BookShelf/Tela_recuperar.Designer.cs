namespace BookShelf
{
    partial class Tela_recuperar
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
            groupBox1 = new GroupBox();
            btnVoltar = new Button();
            btnAlterar = new Button();
            txt_senha = new TextBox();
            label2 = new Label();
            txt_email = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 254, 255);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 320);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnVoltar);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(txt_senha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(159, 14);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(267, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Redefinir Senha";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Indigo;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.Control;
            btnVoltar.Location = new Point(98, 219);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(60, 27);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(192, 0, 0);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.Control;
            btnAlterar.Location = new Point(91, 188);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 27);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(38, 150);
            txt_senha.Margin = new Padding(2);
            txt_senha.MaxLength = 8;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(187, 25);
            txt_senha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(38, 89);
            txt_email.Margin = new Padding(2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(187, 25);
            txt_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Tela_recuperar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Tela_recuperar";
            Size = new Size(595, 320);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txt_senha;
        private Label label2;
        private TextBox txt_email;
        private Label label1;
        private Button btnAlterar;
        private Button btnVoltar;
    }
}
