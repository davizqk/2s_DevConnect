
using Microsoft.AspNetCore;
using CadAlunos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CadAlunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly CadAlunosContext _context;
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger, CadAlunosContext context)
        {
            _logger = logger;
            _context = context;
        }

        // private static List<Aluno> alunos = new List<Aluno>
        // {
        //     new Aluno{ Id = 1, Idade = 17, Nome = "Davi",    Cpf = "99988877766" },
        //     new Aluno{ Id = 2, Idade = 17, Nome = "Walyson", Cpf = "11122233344" },
        //     new Aluno{ Id = 3, Idade = 17, Nome = "Paulo",   Cpf = "44455566677" },
        //     new Aluno{ Id = 4, Idade = 17, Nome = "Matheus", Cpf = "99922277755" },
        //     new Aluno{ Id = 5, Idade = 17, Nome = "Lorenzo", Cpf = "00011133322" },
        //     new Aluno{ Id = 6, Idade = 17, Nome = "Hugo",    Cpf = "77799955533" },
        //     new Aluno{ Id = 7, Idade = 17, Nome = "Gabriel", Cpf = "22200055511" }
        // };

        public async Task<IActionResult> Index()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return View(alunos);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            _context.Add(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // Método para salvar um aluno
        // public IActionResult Create(Aluno aluno)
        // {
        //     // cria o próximo id
        //     // aluno.Id = alunos.Max(a => a.Id) + 1;
        //     // // salvar no array
        //     // alunos.Add(aluno);
        //     // redirecionar o usuário para o Index
        //     return RedirectToAction("Index");
        // }
        public IActionResult Aluno()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}