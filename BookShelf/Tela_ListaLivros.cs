using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookShelf
{
    public partial class Tela_ListaLivros : UserControl
    {
        public Tela_ListaLivros()
        {
            InitializeComponent();
        }

        private int IdLivro;

        private void btnVoltarBuscaLivros_Click(object sender, EventArgs e)
        {
            Form formAtual = this.FindForm();
            formAtual?.Close();

            Tela_BuscarLivro formBusca = new Tela_BuscarLivro();
            formBusca.Show();
        }

        private void Tela_ListaLivros_Load(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.ListarLivros(dtgListarLivros);
        }

        private void dtgListarLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow linha = dtgListarLivros.Rows[e.RowIndex];
                    IdLivro = Convert.ToInt32(linha.Cells["id"].Value);
                    txtTitulo.Text = linha.Cells["titulo"].Value.ToString();
                    txtAutor.Text = linha.Cells["autor"].Value.ToString();
                    txtEditora.Text = linha.Cells["editora"].Value.ToString();
                    txtCategoria.Text = linha.Cells["categoria"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editora = txtEditora.Text;
                string categoria = txtCategoria.Text;

                if (IdLivro > 0)
                {
                    if (!string.IsNullOrWhiteSpace(titulo) &&
                        !string.IsNullOrWhiteSpace(autor) &&
                        !string.IsNullOrWhiteSpace(editora) &&
                        !string.IsNullOrWhiteSpace(categoria))
                    {
                        string conexaoBanco = "Server=localhost; Database=bookshelf_db; Uid=root; pwd='';";
                        MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                        conexao.Open();

                        string atualizarLivros = "UPDATE livros SET titulo = @titulo, autor = @autor, editora = @editora, categoria = @categoria WHERE id = @id";
                        MySqlCommand comando = new MySqlCommand(atualizarLivros, conexao);

                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@autor", autor);
                        comando.Parameters.AddWithValue("@editora", editora);
                        comando.Parameters.AddWithValue("@categoria", categoria);
                        comando.Parameters.AddWithValue("@id", IdLivro);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados atualizados com sucesso.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTitulo.Clear();
                        txtAutor.Clear();
                        txtEditora.Clear();
                        txtCategoria.Clear();

                        Livro livro = new Livro();
                        livro.ListarLivros(dtgListarLivros);
                    }
                    else
                    {
                        MessageBox.Show("Todos os campos devem estar preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um livro no DataGrid com duplo clique primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdLivro > 0)
                {
                    var resultado = MessageBox.Show("Você tem certeza que deseja excluir esse livro?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        string conexaoBanco = "Server=localhost; Database=bookshelf_db; Uid=root; pwd='';";
                        MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                        conexao.Open();

                        string deletarLivro = "DELETE FROM livros WHERE id = @id;";
                        MySqlCommand comando = new MySqlCommand(deletarLivro, conexao);
                        comando.Parameters.AddWithValue("@id", IdLivro);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Livro excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTitulo.Clear();
                        txtAutor.Clear();
                        txtEditora.Clear();
                        txtCategoria.Clear();

                        Livro livro = new Livro();
                        livro.ListarLivros(dtgListarLivros);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um livro no DataGrid com duplo clique primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
