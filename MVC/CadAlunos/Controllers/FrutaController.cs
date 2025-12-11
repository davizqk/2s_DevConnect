
using CadAlunos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadAlunos.Controllers
{
    public class FrutaController : Controller
    {

        private readonly ILogger<FrutaController> _logger;

        public readonly CadAlunosContext _context;

        public FrutaController(ILogger<FrutaController> logger, CadAlunosContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Criar uma lista de Frutas
        // private static List<Fruta> frutas = new List<Fruta>
        // {
        //     new Fruta{ Id = 1, Nome = "Maçã",    Cor = "Vermelha",  Categoria = "Tropical" },
        //     new Fruta{ Id = 2, Nome = "Banana",  Cor = "Amarela",   Categoria = "Tropical" },
        //     new Fruta{ Id = 3, Nome = "Uva",     Cor = "Roxa",      Categoria = "Tropical" },
        //     new Fruta{ Id = 4, Nome = "Limão",   Cor = "Verde",     Categoria = "Citrica" },
        //     new Fruta{ Id = 5, Nome = "Abacaxi", Cor = "Amarelo",   Categoria = "Citrica" },
        //     new Fruta{ Id = 6, Nome = "Laranja", Cor = "Laranja",   Categoria = "Citrica" }
        // };

        public async Task<IActionResult> Index()
        {
            var frutas = await _context.Fruta.ToListAsync();
            return View(frutas);
        }
        // Action para cadastrar uma fruta - Formulário (Viewl)
        public IActionResult Create()
        {
            return View();
        }
        // Método para salvar uma fruta
        [HttpPost]
        public IActionResult Create(Fruta fruta)
        {
            // // cria o próximo id
            // fruta.Id = frutas.Max(f => f.Id) + 1;
            // // salvar no array
            // frutas.Add(fruta);
            // // redirecionar o usuário para o Index
            return RedirectToAction("Index");
        }
        public IActionResult FrutaCitrica()
        {
            return View();
        }
        public IActionResult FrutaTropical()
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