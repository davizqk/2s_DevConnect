
using System.Threading.Tasks;
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Controllers
{
    public class FeedController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                // são todas as publicacoes
                List<TbPublicacao> publicacoes = await _context.TbPublicacao.Include(p => p.IdUsuarioNavigation).ToListAsync();
                // listar as publis
                return View(publicacoes);
            }
            catch (System.Exception)
            {
                
                throw;
            }

        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbPublicacao novoPost = new TbPublicacao
            {
                Descricao = form["Descricao"].ToString(),
                DataPublicacao = DateOnly.FromDateTime(DateTime.Now)
            };

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                //Se não existir
                if (!Directory.Exists(folder))
                {
                    //Cria a pasta images
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoPost.ImagemUrl = file.FileName;
            }
            
            try
            {
                _context.TbPublicacao.Add(novoPost);

                await _context.SaveChangesAsync();

                ViewBag.PublicacaoCadastrada = "Cadastrada";

                return View();
            }
            catch (System.Exception)
            {
                ViewBag.PublicacaoCadastrada = "Nao cadastrada";
                // listar as publis
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}