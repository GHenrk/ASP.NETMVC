using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {

        private readonly ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            return View();
        }
    }
}
