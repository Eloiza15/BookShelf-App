using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookShelf
{
    internal class BancoDb
    {
       private string conexaoBanco = "Server=localhost; Database=bookshelf_db; Uid=root; Pws=;";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);
            conexao.Open();
            return conexao;
        }
    }
}
