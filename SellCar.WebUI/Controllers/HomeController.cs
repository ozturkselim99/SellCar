using Microsoft.AspNetCore.Mvc;
using sellcar.business.Abstract;
using sellcar.webui.Models;

namespace SellCar.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IIlanService _ilanService;
        public HomeController(IIlanService ilanService)
        {
            _ilanService = ilanService;
        }
        public IActionResult Index()
        {
            var model = new IlanListViewModel()
            {
                ilanlar = _ilanService.GetAnasayfaIlanlari()
            };
            return View(model);
        }
        public IActionResult Search(string q)
        {
            var model = new IlanListViewModel()
            {
                ilanlar = _ilanService.GetSearchResult(q)
            };
            return View(model);
        }
    }
}