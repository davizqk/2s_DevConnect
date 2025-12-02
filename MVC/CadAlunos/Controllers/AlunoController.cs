
using CadAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadAlunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }
        private static List<Aluno> alunos = new List<Aluno>
        {
            new Aluno{ Id = 1, Idade = 17, Nome = "Davi",    Serie = "2A" },
            new Aluno{ Id = 2, Idade = 17, Nome = "Walyson", Serie = "2A" },
            new Aluno{ Id = 3, Idade = 17, Nome = "Paulo",   Serie = "2A" },
            new Aluno{ Id = 4, Idade = 17, Nome = "Matheus", Serie = "2A" },
            new Aluno{ Id = 5, Idade = 17, Nome = "Lorenzo", Serie = "2A" },
            new Aluno{ Id = 6, Idade = 17, Nome = "Hugo",    Serie = "2A" },
            new Aluno{ Id = 7, Idade = 17, Nome = "Gabriel", Serie = "2A" }
        };

        public IActionResult Index()
        {
            return View(alunos);
        }
        public IActionResult Create()
        {
            return View();
        }
        // Método para salvar um aluno
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            // cria o próximo id
            aluno.Id = alunos.Max(a => a.Id) + 1;
            // salvar no array
            alunos.Add(aluno);
            // redirecionar o usuário para o Index
            return RedirectToAction("Index");
        }
        public IActionResult Aluno()
        {
            return View(alunos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}