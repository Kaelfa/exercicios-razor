using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnet_mvc.Models;
using aspnet_mvc.ViewModels;
using Microsoft.AspNetCore.Mvc.Routing;

namespace aspnet_mvc.Controllers
{
    public class EventoController : Controller
    {
        private static List<Evento> _eventos = new()
        {
            new Evento {Id = 1, Nome = "BGS 2026", Descricao = "Um evento onde a cultura pop se une ao mundo real",Local = "Rua da esperanca" , DataEvento = DateTime.Today, QuantidadeVagas = 67},
            new Evento {Id = 2, Nome = "Campeonato de Poker SENAI", Descricao = "Uma competicao onde os melhores batalham para ganhar", Local = "SENAi Antônio Paulo Skaff", DataEvento = DateTime.Today, QuantidadeVagas = 20}
        };

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_eventos);
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return View(new BuscaEventoViewModel());
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Evento e)
        {
            e.Id = _eventos.Any() ? _eventos.Max(a => a.Id) + 1 : 1;
            _eventos.Add(e);
            return RedirectToAction("Listar");
        }

    }
}