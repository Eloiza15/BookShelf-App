using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    public partial class Tela_BuscarLivro : Form
    {
        public Tela_BuscarLivro()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var api = new GoogleBooksAPI();
            var livro = await api.BuscarLivroPorTitulo(txtBuscarLivro.Text);

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblTitulo.Text = livro.Titulo;
            lblAutor.Text = livro.Autor;
            lblEditora.Text = livro.Editora;
            lblCategoria.Text = livro.Categoria;

            if (!String.IsNullOrEmpty(livro.CapaUrl))
                picCapa.Load(livro.CapaUrl);
        }

        private void btnEstante_Click(object sender, EventArgs e)
        {
            Tela_ListaLivros listaLivrosUC = new Tela_ListaLivros();

            panelBuscaLivro.Controls.Clear();
            listaLivrosUC.Dock = DockStyle.Fill;
            panelBuscaLivro.Controls.Add(listaLivrosUC);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTitulo.Text == "<titulo>")
                {
                    MessageBox.Show("Por favor, busque um livro antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Livro livros = new Livro();
                livros.Titulo = lblTitulo.Text;
                livros.Autor = lblAutor.Text;
                livros.Editora = lblEditora.Text;
                livros.Categoria = lblCategoria.Text;
                livros.CapaUrl = lblCapa.Text;

                livros.SalvarLivro(); // Mensagem já tratada na própria classe Livro

                Tela_ListaLivros listaLivrosUC = new Tela_ListaLivros();

                panelBuscaLivro.Controls.Clear();
                listaLivrosUC.Dock = DockStyle.Fill;
                panelBuscaLivro.Controls.Add(listaLivrosUC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao tentar salvar o livro.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
