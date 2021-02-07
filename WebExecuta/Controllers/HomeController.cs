using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Metodos;
using Biblioteca.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebExecuta.Models;

namespace WebExecuta.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Gravar()
		{
			MeusMetodos meusMetodos = new MeusMetodos();
			meusMetodos.Envia += new GravaArquivoService().Executa;
			meusMetodos.ExecutaMetodo("Gravado com sucesso!");

			return View();

		}

		public IActionResult Deletar()
		{
			MeusMetodos meusMetodos = new MeusMetodos();
			meusMetodos.Envia += new ApagaArquivoService().Executa;
			meusMetodos.ExecutaMetodo("Apagado com sucesso!");
			return View();
		}
	}
}
