using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tg_crud_solution.Models;
using tg_crud_solution.Models.DataBase;
using tg_crud_solution.Services.ClientService;
using tg_crud_solution.ViewModels;

namespace tg_crud_solution.Controllers
{
    public class HomeController : Controller
    {
        public IClientService Service;

        public HomeController(IClientService service)
        {
            this.Service = service;
        }

        public IActionResult Index()
        {
            List<Client> clients = this.Service.GetClients();


            IndexViewModel ivm = new IndexViewModel() { Title = "Клиенты", Clients = clients };
            return View(ivm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
