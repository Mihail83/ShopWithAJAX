using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopWithAJAX.WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ShopWithAJAX.BLL.BusinessLogic;
using ShopWithAJAX.BLL.BusinessModel;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.WEB.Mapper;

namespace ShopWithAJAX.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ShopSupplier _shopSupplier;

        public HomeController(ILogger<HomeController> logger, ShopSupplier shopSupplier)
        {
            _logger = logger;
            _shopSupplier = shopSupplier;
        }

        public IActionResult Index([FromServices]IMapper<Shop, ShopMinViewModel> mapper)
        {
            var shopsMinViewModel = new List<ShopMinViewModel>();

            foreach (var shop in _shopSupplier.GetShops())   
            {
                shopsMinViewModel.Add(mapper.Map(shop));
            }
            return View(shopsMinViewModel);
        }

        public IActionResult GetInformationAboutShop(int id)
        {
            Shop shopInformation;
            try
            {
                shopInformation = _shopSupplier.GetShopById(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }            
            return PartialView(new ShopFullnfoViewModel(shopInformation));
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
