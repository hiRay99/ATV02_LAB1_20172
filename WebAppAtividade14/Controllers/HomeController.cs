using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAtividade14.Models;

namespace WebAppAtividade14.Controllers
{
    public class HomeController : Controller
    {
        private static List<Aluno> Alunos = null;
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre(int id)
        {
            var aluno = Alunos.Where(a=>a.AlunoId == id);
            return View(aluno);

        }


    }
}