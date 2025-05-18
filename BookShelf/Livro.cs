using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace BookShelf
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Categoria { get; set; }
        public string CapaUrl { get; set; }

        public bool SalvarLivro()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string inserir = "insert into livros (titulo, autor, editora, categoria) value (@titulo, @autor, @editora, @categoria)";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@titulo", Titulo);
                    comando.Parameters.AddWithValue("@autor", Autor);
                    comando.Parameters.AddWithValue("@editora", Editora);
                    comando.Parameters.AddWithValue("@categoria", Categoria);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Livro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível salvar o livro. Tente novamente.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o livro:\n" + ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ListarLivros(DataGridView dataGrid)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string listar = "select * from livros";
                    MySqlCommand comando = new MySqlCommand(listar, conexaoBanco);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGrid.DataSource = tabela;

                    // Configurações do DataGridView
                    dataGrid.AllowUserToAddRows = false;
                    dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGrid.AutoResizeColumns();
                    dataGrid.ClearSelection();

                    if (dataGrid.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum livro encontrado.", "Lista vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar os livros:\n" + ex.Message, "Erro de listagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
