using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sellcar.business.Abstract;
using sellcar.webui.Identity;
using sellcar.webui.Models;

namespace SellCar.WebUI.Controllers
{
    public class CarController : Controller
    {
        private IIlanService _ilanService;
        private IIlService _ilService;
        private IFavService _favService;
        private UserManager<User> _userManager;

        public CarController(IIlanService ilanService, UserManager<User> userManager,IIlService ilService, IFavService favService)
        {
            _ilanService = ilanService;
            _ilService = ilService;
            _favService = favService;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult List(string url)
        {
            var model = new IlanListViewModel()
            {
                ilanlar = _ilanService.GetIlanlar(url),
            };
            ViewBag.markaurl = (RouteData.Values["url"] == null) ? "" : RouteData.Values["url"];
            ViewBag.iller = _ilService.GetIller();
            return View(model);
        }
        [HttpPost]
        public IActionResult List(string url, string min_fiyat, string max_fiyat, string min_kilometre, string max_kilometre, string min_yil, string max_yil, string[] yakit_tipi, string[] vites_tipi, string[] kasa_tipi, string min_beygir, string max_beygir, string[] cekis, string[] renk, string kimden, string durumu, string takasli,string[]il)
        {
            var model = new IlanListViewModel()
            {
                ilanlar = _ilanService.Filter(url, min_fiyat, max_fiyat, min_kilometre, max_kilometre, min_yil, max_yil, yakit_tipi, vites_tipi, kasa_tipi, min_beygir, max_beygir, cekis, renk, kimden, durumu, takasli,il),
                yakit_tipi = yakit_tipi,
                vites_tipi = vites_tipi,
                kasa_tipi = kasa_tipi,
                cekis = cekis,
                renk = renk,
                min_fiyat = min_fiyat,
                max_fiyat = max_fiyat,
                min_kilometre = min_kilometre,
                max_kilometre = max_kilometre,
                min_yil = min_yil,
                max_yil = max_yil,
                min_beygir = min_beygir,
                max_beygir = max_beygir,
                kimden = kimden,
                durumu = durumu,
                takasli = takasli,
                il=il,
            };
            ViewBag.markaurl = RouteData.Values["url"];
            ViewBag.iller = _ilService.GetIller();

            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            var ilan = _ilanService.GetIlanDetail((int)id);
            var user = await _userManager.FindByIdAsync(ilan.userId);

            var favoriilanlar = _favService.GetFavByUserId(_userManager.GetUserId(User));
            if (id == null)
            {
                return NotFound();
            }
            var model = new IlanDetailViewModel()
            {
                ilan = ilan,
                user = user,
                ilanResimleri = ilan.IlanResimleri,
                ilanFavorilerdemi= favoriilanlar.Any(i => i.IlanId == id)
        };
            return View(model);
        }
        public async Task<IActionResult> UserIlans(string id)
        {
            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == id).ToList();
            var user = await _userManager.FindByIdAsync(id);
            var model = new UserIlanListViewModel()
            {
                ilanlar = ilanlar,
                user = user,
            };
            return View(model);
        }
    }
}