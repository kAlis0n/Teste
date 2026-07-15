using Microsoft.AspNetCore.Mvc;
using Skynetz.Models;
using System.Diagnostics;

namespace Skynetz.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Tarifa> _tarifas = new List<Tarifa>
        {
            new Tarifa { DDDs = "011 para 016", ValorTarifa = 1.90m },
            new Tarifa { DDDs = "016 para 011", ValorTarifa = 2.90m },
            new Tarifa { DDDs = "011 para 017", ValorTarifa = 1.70m },
            new Tarifa { DDDs = "017 para 011", ValorTarifa = 2.70m },
            new Tarifa { DDDs = "011 para 018", ValorTarifa = 0.90m },
            new Tarifa { DDDs = "018 para 011", ValorTarifa = 1.90m }
        };

        private readonly List<Plano> _planos = new List<Plano>
        {
            new Plano { Planos = "FaleMais 30", Franquia = 30 },
            new Plano { Planos = "FaleMais 60", Franquia = 60 },
            new Plano { Planos = "FaleMais 120", Franquia = 120 }
        };

        [HttpGet]
        public IActionResult Index()
        {
            var model = new Calculo
            {
                Tarifas = _tarifas,
                Planos = _planos,
                Minutos = 0
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Calculo model)
        {
            {
                model.Tarifas = _tarifas;
                model.Planos = _planos;

                var tarifaSelecionada = _tarifas.FirstOrDefault(t => t.DDDs == model.DDDsSelecionado);
                var planoSelecionado = _planos.FirstOrDefault(p => p.Franquia == model.PlanoSelecionado);

                if (tarifaSelecionada != null && planoSelecionado != null)
                {
                    decimal tarifa = tarifaSelecionada.ValorTarifa;
                    int plano = planoSelecionado.Franquia;
                    int min = model.Minutos;

                    model.CustoSemPlano = min * tarifa;

                    model.CustoComPlano = 0;
                    if(min > plano)
                    {
                        int excesso = min - plano;
                        decimal acrescimo = tarifa * 1.1m;
                        model.CustoComPlano = excesso * acrescimo;
                    }
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
