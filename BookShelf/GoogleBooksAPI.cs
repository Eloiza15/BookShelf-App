using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BookShelf
{
    internal class GoogleBooksAPI
    {
        public async Task<Livro> BuscarLivroPorTitulo(string titulo)
        {
            string url = $"https://www.googleapis.com/books/v1/volumes?q=intitle:{Uri.EscapeDataString(titulo)}";

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(url);
                JObject obj = JObject.Parse(json);

                var info = obj["items"]?[0]?["volumeInfo"];
                if (info == null) return null;

                return new Livro
                {
                    Titulo = info["title"]?.ToString(),
                    Autor = info["authors"]?[0]?.ToString(),
                    Editora = info["publisher"]?.ToString(),
                    Categoria = info["categories"]?[0]?.ToString(),
                    CapaUrl = info["imageLinks"]?["thumbnail"]?.ToString()
                };
            }
        }
    }
}
