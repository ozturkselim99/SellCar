using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sellcar.business.Abstract;
using sellcar.webui.Helpers;
using sellcar.webui.Models;

namespace sellcar.webui.Controllers
{
    public class CartController : Controller
    {
        private IIlanService _ilanService;

        public CartController(IIlanService ilanService)
        {
            _ilanService = ilanService;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<IlanItemModel>>(HttpContext.Session, "cart");
            return View(cart);
        }

        [Route("add/{id}")]
        public IActionResult Add(int id)
        {
            var entity = _ilanService.GetIlanDetail(id);
            if (SessionHelper.GetObjectFromJson<List<IlanItemModel>>(HttpContext.Session, "cart") == null)
            {
                List<IlanItemModel> cart = new List<IlanItemModel>();

                cart.Add(new IlanItemModel
                {
                    IlanId = entity.IlanId,
                    seri = entity.seri,
                    model = entity.model,
                    yil = entity.yil,
                    yakitTipi = entity.yakitTipi,
                    vitesTipi = entity.vitesTipi,
                    vitesSayisi = entity.vitesSayisi,
                    kilometre = entity.kilometre,
                    kasaTipi = entity.kasaTipi,
                    kapiSayisi = entity.kapiSayisi,
                    motorGücü = entity.motorGücü,
                    motorHacmi = entity.motorHacmi,
                    azamiSurati = entity.azamiSurati,
                    hizlanma = entity.hizlanma,
                    cekisTipi = entity.cekisTipi,
                    sehirIciTuketim = entity.sehirIciTuketim,
                    sehirDisiTuketim = entity.sehirDisiTuketim,
                    ortalamaTuketim = entity.ortalamaTuketim,
                    yakitDepoHacmi = entity.yakitDepoHacmi,
                    renk = entity.renk,
                    fiyat = entity.fiyat,
                    markaId = entity.markaId,
                    resimUrl = entity.IlanResimleri[0].url,
                    markaAdi = entity.Marka.adi

                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<IlanItemModel> cart = SessionHelper.GetObjectFromJson<List<IlanItemModel>>(HttpContext.Session, "cart");
                cart.Add(new IlanItemModel
                {
                    IlanId = entity.IlanId,
                    seri = entity.seri,
                    model = entity.model,
                    yil = entity.yil,
                    yakitTipi = entity.yakitTipi,
                    vitesTipi = entity.vitesTipi,
                    vitesSayisi = entity.vitesSayisi,
                    kilometre = entity.kilometre,
                    kasaTipi = entity.kasaTipi,
                    kapiSayisi = entity.kapiSayisi,
                    motorGücü = entity.motorGücü,
                    motorHacmi = entity.motorHacmi,
                    azamiSurati = entity.azamiSurati,
                    hizlanma = entity.hizlanma,
                    cekisTipi = entity.cekisTipi,
                    sehirIciTuketim = entity.sehirIciTuketim,
                    sehirDisiTuketim = entity.sehirDisiTuketim,
                    ortalamaTuketim = entity.ortalamaTuketim,
                    yakitDepoHacmi = entity.yakitDepoHacmi,
                    renk = entity.renk,
                    fiyat = entity.fiyat,
                    markaId = entity.markaId,
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<IlanItemModel> cart = SessionHelper.GetObjectFromJson<List<IlanItemModel>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<IlanItemModel> cart = SessionHelper.GetObjectFromJson<List<IlanItemModel>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].IlanId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}