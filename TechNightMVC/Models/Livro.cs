using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TechNightMVC.Models
{
    public class Livro
    {
        [Required(ErrorMessage = "O Código é obrigatório!")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O Título é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Autor é obrigatório!")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O Ano é obrigatório!")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "O Ano deve possuir 4 números!")]
        public int Ano { get; set; }

        public Collection<Livro> Livros()
        {
            var retorno = new Collection<Livro>
            {
                new Livro
                {
                    Codigo = 1,
                    Titulo = "Senhor dos Anéis",
                    Autor = "Tolkien",
                    Ano = 2000
                },
                new Livro
                {
                    Codigo = 2,
                    Titulo = "Sherlock Holmes",
                    Autor = "Conan Doyle",
                    Ano = 1980
                },
                new Livro
                {
                    Codigo = 3,
                    Titulo = "O Colecionador de Ossos",
                    Autor = "Desconhecido",
                    Ano = 2004
                }
            };
            return retorno;
        }
    }
}
