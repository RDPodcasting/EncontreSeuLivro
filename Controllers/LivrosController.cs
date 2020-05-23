using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EncontreSeuLivro.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Busca()
        {
            return View();
        }

        public IActionResult Lancamentos()
        {
            return View();
        }
    }
}