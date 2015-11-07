using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechNightMVC.Models;

namespace TechNightMVC.Controllers
{
    public class HomeController : Controller
    {
        private static Collection<Livro> livros;

        public HomeController()
        {
            if (livros == null)
                livros = new Livro().Livros();
        }

        public ActionResult Index()
        {
            return View(livros);
        }

        [HttpPost]
        public ActionResult Index(Livro livro)
        {
            return View(livros);
        }

        public ActionResult NovoLivro()
        {
            return View();
        }

        public ActionResult EditarLivro(int codigo)
        {
            return View(livros.FirstOrDefault(x => x.Codigo == codigo));
        }

        public ActionResult InserirLivro(Livro livro)
        {
            if (ModelState.IsValid)
            {
                if (livros.FirstOrDefault(x => x.Codigo == livro.Codigo) == null)
                    livros.Add(livro);
                return RedirectToAction("Index", livros);
            }
            else
                return View("NovoLivro", livro);
        }

        public ActionResult AtualizarLivro(Livro livro)
        {
            if (ModelState.IsValid)
            {
                Livro livroAtualizar = livros.FirstOrDefault(x => x.Codigo == livro.Codigo);
                livroAtualizar.Titulo = livro.Titulo;
                livroAtualizar.Autor = livro.Autor;
                livroAtualizar.Ano = livro.Ano;
                return RedirectToAction("Index", livros);
            }
            else
                return View("EditarLivro", livro);
        }

        public ActionResult ExcluirLivro(int codigo)
        {
            livros.Remove(livros.FirstOrDefault(x => x.Codigo == codigo));
            return RedirectToAction("Index", livros);
        }
    }
}