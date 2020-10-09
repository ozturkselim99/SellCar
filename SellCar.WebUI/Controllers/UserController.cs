using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using sellcar.business.Abstract;
using sellcar.entity;
using sellcar.webui.Identity;
using sellcar.webui.Models;

namespace sellcar.webui.Controllers
{
    [Authorize(Roles = "user")]
    public class UserController : Controller
    {
        Random rnd;
        private IIlanService _ilanService;
        private IResimService _resimService;
        private IMarkaService _markaService;
        private IFavService _favService;
        private IIlService _ilService;
        private UserManager<User> _userManager;
        public UserController(IIlanService ilanService, IResimService resimService, IMarkaService markaService, UserManager<User> userManager, IFavService favService, IIlService ilService)
        {
            _ilanService = ilanService;
            _resimService = resimService;
            _markaService = markaService;
            _userManager = userManager;
            _favService = favService;
            _ilService = ilService;
            rnd = new Random();
        }
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == Convert.ToString(user.Id)).ToList();
            var favs = _favService.GetFavByUserId(_userManager.GetUserId(User));
            ViewBag.favs = favs.Count();
            ViewBag.ilansayisi = ilanlar.Count();
            var model = new UserProfileModel()
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                MembershipDate = user.MembershipDate.ToString().TrimEnd('0', ':'),
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UserProfileEdit(UserProfileModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == Convert.ToString(user.Id)).ToList();
            var favs = _favService.GetFavByUserId(_userManager.GetUserId(User));

            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return Redirect("/user/profile");
                }
            }
            return RedirectToAction("Profile", model);
        }


        public IActionResult CreateIlan()
        {
            ViewBag.Markalar = _markaService.GetMarkalar();
            ViewBag.Iller = _ilService.GetIller();
            return View(new CreateIlanModel());
        }
        [HttpPost]
        public IActionResult CreateIlan(CreateIlanModel ilan, List<IFormFile> files)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Markalar = _markaService.GetMarkalar();
                ViewBag.Iller = _ilService.GetIller();
                return View(ilan);
            }
            int randomsayi = rnd.Next(100000000, 999999999);
            var entity = new Ilan
            {
                IlanId = randomsayi,
                ilanBasligi = ilan.ilanBasligi,
                ilanDetay = ilan.ilanDetay,
                ilId = Convert.ToInt32(ilan.ilId),
                seri = ilan.seri,
                model = ilan.model,
                yil = ilan.yil,
                yakitTipi = ilan.yakitTipi,
                vitesTipi = ilan.vitesTipi,
                kilometre = ilan.kilometre,
                kasaTipi = ilan.kasaTipi,
                motorGücü = ilan.motorGücü,
                motorHacmi = ilan.motorHacmi,
                azamiSurati = ilan.azamiSurati,
                hizlanma = ilan.hizlanma,
                cekisTipi = ilan.cekisTipi,
                sehirIciTuketim = ilan.sehirIciTuketim,
                sehirDisiTuketim = ilan.sehirDisiTuketim,
                renk = ilan.renk,
                kimden = ilan.kimden,
                takas = ilan.takas,
                durum = ilan.durum,
                fiyat = ilan.fiyat,
                ilanTarihi = DateTime.Now,
                markaId = Convert.ToInt32(ilan.markaId),
                userId = _userManager.GetUserId(User)
            };
            _ilanService.Create(entity);
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {

                        var fileName = Path.GetFileName(file.FileName);
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = Path.GetExtension(fileName);
                        var newFileName = String.Concat(myUniqueFileName, fileExtension);
                        var resim = new Resim()
                        {
                            url = newFileName,
                            IlanId = randomsayi,
                        };
                        _resimService.Create(resim);

                        var filepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";
                        using (FileStream fs = System.IO.File.Create(filepath))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            TempData["message"] = $"{ entity.ilanBasligi} başlıklı {entity.IlanId} ilan numarasına sahip araç yayındadır.";
            return Redirect("/cars");
        }
        [HttpGet]
        public IActionResult IlanEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _ilanService.GetIlanDetail((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new EditIlanModel()
            {
                IlanId = entity.IlanId,
                ilanBasligi = entity.ilanBasligi,
                ilanDetay = entity.ilanDetay,
                ilId = Convert.ToString(entity.ilId),
                seri = entity.seri,
                model = entity.model,
                yil = entity.yil,
                yakitTipi = entity.yakitTipi,
                vitesTipi = entity.vitesTipi,
                kilometre = entity.kilometre,
                kasaTipi = entity.kasaTipi,
                motorGücü = entity.motorGücü,
                motorHacmi = entity.motorHacmi,
                azamiSurati = entity.azamiSurati,
                hizlanma = entity.hizlanma,
                cekisTipi = entity.cekisTipi,
                sehirIciTuketim = entity.sehirIciTuketim,
                sehirDisiTuketim = entity.sehirDisiTuketim,
                renk = entity.renk,
                kimden = entity.kimden,
                takas = entity.takas,
                durum = entity.durum,
                fiyat = entity.fiyat,
                markaId = Convert.ToString(entity.markaId),
                IlanResimleri = entity.IlanResimleri,

            };
            ViewBag.Markalar = _markaService.GetMarkalar();
            ViewBag.Iller = _ilService.GetIller();
            return View(model);
        }
        [HttpPost]
        public IActionResult IlanEdit(EditIlanModel ilanmodel, List<IFormFile> files)
        {
            if (!ModelState.IsValid)
            {
                var ilan = _ilanService.GetIlanDetail(ilanmodel.IlanId);
                ilanmodel.IlanResimleri = ilan.IlanResimleri;
                ViewBag.Markalar = _markaService.GetMarkalar();
                ViewBag.Iller = _ilService.GetIller();
                return View(ilanmodel);
            }
            var entity = _ilanService.GetById(ilanmodel.IlanId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.ilanBasligi = ilanmodel.ilanBasligi;
            entity.ilanDetay = ilanmodel.ilanDetay;
            entity.ilId = Convert.ToInt32(ilanmodel.ilId);
            entity.seri = ilanmodel.seri;
            entity.model = ilanmodel.model;
            entity.yil = ilanmodel.yil;
            entity.yakitTipi = ilanmodel.yakitTipi;
            entity.vitesTipi = ilanmodel.vitesTipi;
            entity.kilometre = ilanmodel.kilometre;
            entity.kasaTipi = ilanmodel.kasaTipi;
            entity.motorGücü = ilanmodel.motorGücü;
            entity.motorHacmi = ilanmodel.motorHacmi;
            entity.azamiSurati = ilanmodel.azamiSurati;
            entity.hizlanma = ilanmodel.hizlanma;
            entity.cekisTipi = ilanmodel.cekisTipi;
            entity.sehirIciTuketim = ilanmodel.sehirIciTuketim;
            entity.sehirDisiTuketim = ilanmodel.sehirDisiTuketim;
            entity.renk = ilanmodel.renk;
            entity.kimden = ilanmodel.kimden;
            entity.takas = ilanmodel.takas;
            entity.durum = ilanmodel.durum;
            entity.fiyat = ilanmodel.fiyat;
            entity.markaId = Convert.ToInt32(ilanmodel.markaId);
            _ilanService.Update(entity);

            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {

                        var fileName = Path.GetFileName(file.FileName);
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = Path.GetExtension(fileName);
                        var newFileName = String.Concat(myUniqueFileName, fileExtension);
                        var resim = new Resim()
                        {
                            url = newFileName,
                            IlanId = ilanmodel.IlanId,
                        };
                        _resimService.Create(resim);

                        var filepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";
                        using (FileStream fs = System.IO.File.Create(filepath))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            TempData["message"] = $"{ entity.ilanBasligi} başlıklı {entity.IlanId} araç bilgileri düzenlendi.";
            TempData["alert-type"] = "alert-warning";
            return Redirect("/user/ilanlarim");
        }
        public IActionResult IlanDelete(int? id)
        {
            var entity = _ilanService.GetById((int)id);
            if (entity != null)
            {
                _ilanService.Delete(entity);
            }
            TempData["message"] = $"{ entity.ilanBasligi} başlıklı {entity.IlanId} araç yayından kaldırıldı.";
            TempData["alert-type"] = "alert-danger";
            return Redirect("/user/ilanlarim");
        }
        public IActionResult IlanResimDelete(string id)
        {
            var resim = _resimService.GetByUrl(id);
            if (resim != null)
            {
                _resimService.Delete(resim);
            }
            TempData["message"] = "Resim silindi";
            return Redirect("/user/ilan/" + resim.IlanId);
        }
        public IActionResult FavIlan()
        {
            var favoriilanlar = _favService.GetFavByUserId(_userManager.GetUserId(User));
            var model = new FavModel()
            {
                Favs = favoriilanlar.Select(i => new FavItemModel()
                {
                    IlanId = i.IlanId,
                    resimUrl = i.Ilan.IlanResimleri[0].url,
                    ilanBasligi = i.Ilan.ilanBasligi,
                    markaAdi = i.Ilan.Marka.adi,
                    seri = i.Ilan.seri,
                    model = i.Ilan.model,
                    fiyat = i.Ilan.fiyat
                }).ToList()
            };
            return View(model);
        }
        public IActionResult CreateFavIlan(int? id)
        {
            var userId = _userManager.GetUserId(User);
            _favService.Create(new Fav()
            {
                IlanId = (int)id,
                UserId = userId,
            });
            TempData["message"] = "İlan favorilere eklendi.";
            TempData["alert-type"] = "alert-success";
            return Redirect("/user/favorilerim");
        }
        public IActionResult DeleteFavIlan(int? id)
        {
            var entity = _favService.GetFavByUserId(_userManager.GetUserId(User)).Where(i => i.IlanId == id).FirstOrDefault();
            if (entity != null)
            {
                _favService.Delete(entity);
            }
            TempData["message"] = $"{ entity.Ilan.ilanBasligi} başlıklı  araç favoriden kaldırıldı.";
            TempData["alert-type"] = "alert-danger";
            return Redirect("/user/favorilerim");
        }
        public IActionResult Ozet()
        {
            var userId = _userManager.GetUserId(User);
            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == userId).ToList();
            var favs = _favService.GetFavByUserId(userId);
            ViewBag.favs = favs.Count();
            ViewBag.ilansayisi = ilanlar.Count();
            return View();
        }
        public IActionResult Ilan()
        {
            var userId = _userManager.GetUserId(User);
            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == userId).ToList();
            var model = new IlanListViewModel()
            {
                ilanlar = ilanlar,
            };
            return View(model);
        }
    }
}