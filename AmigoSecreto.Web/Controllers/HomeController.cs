using AmigoSecreto.Web.Models;
using AmigoSecreto.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AmigoSecreto.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiHelper _api;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _api = new();
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeModel = new();

            var result = await _api.GetAsync("/v1/buscar-todos");
            homeModel.Amigos = JsonConvert.DeserializeObject<List<Amigo>>(result).OrderBy(obj => obj.RegistradoEm).ToList();           

            return View(homeModel); 
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            =>View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        public async Task<IActionResult> NovoAmigo(CreateAmigoViewModel model)
        {
            var homeModel = new HomeViewModel();

            if(!ModelState.IsValid)
            {
                homeModel.Feedback = FeedbackModel.Create(Tipo.Error, $"PX4E - Erro ao registrar {model.Name}. Tente novamente, se o problema persistir, contate um administrador.");
                return View("Index", homeModel);
            }

            var emailExiste = JsonConvert.DeserializeObject<bool>(await _api.GetAsync("/v1/email-existe/" + model.Email.Replace(";", "")));

            if(emailExiste)
            {
                homeModel.Feedback = FeedbackModel.Create(Tipo.Info, $"PX43 - Erro ao registrar {model.Name}. O email informado já está em uso.");
                return View("Index", homeModel);
            }

            var result = await _api.PostAync("/v1/registrar", model);
            
            if(result)
            {
                homeModel.Feedback = FeedbackModel.Create(Tipo.Success, $"{model.Name} foi cadastrado com sucesso.");
                return RedirectToAction("Index", homeModel);

            } else
            {
                homeModel.Feedback = FeedbackModel.Create(Tipo.Error, $"PX5E - Erro ao registrar {model.Name}. Tente novamente, se o problema persistir, contate um administrador.");
                return View("Index", homeModel);
            }

        }
    }
}