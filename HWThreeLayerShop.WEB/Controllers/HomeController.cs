using HWThreeLayerShop.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HWThreeLayerShop.BLL.Interfaces;
using HWThreeLayerShop.BLL.BusinessLogic;
using HWThreeLayerShop.DAL.Repositories;
using HWThreeLayerShop.DAL.Exeptions;



namespace HWThreeLayerShop.WEB.Controllers
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
            
            if (HttpContext.Session.GetString("user_name")==null)
            HttpContext.Session.SetString("user_name", "Guest");
            return View();
        }
        public IActionResult Catalog([FromServices] IRepository dataDase, int catalogID = -1)
        {
            CatalogViewModel catalogviewmodel = new CatalogViewModel();
            try
            {
                var catalogs = dataDase.GetAllCatalogDTOs();
                if (catalogID < 0)
                {
                    catalogID = catalogs.First().Id;
                }
                var goods = dataDase.GetGoodDTOsByCataligId(catalogID).GetDiscount();
                catalogviewmodel = new CatalogViewModel(catalogs, goods);
            }
            catch (NotFoundExeption ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"something wrong in  {ex.Source}" );
            }

            return View(catalogviewmodel);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                HttpContext.Session.SetString("user_name", name);
            }
            return RedirectToAction("Login", "Home");
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
    }
}
