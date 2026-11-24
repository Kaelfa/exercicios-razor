using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_mvc.Models;

namespace aspnet_mvc.ViewModels
{
    public class BuscaEventoViewModel
    {
        public string? TermoBusca{get; set;}
        public List<Evento> Resultado {get; set;} = new();
    }
}