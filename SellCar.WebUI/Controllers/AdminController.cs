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
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IIlanService _ilanService;
        private IMarkaService _markaService;
        private IResimService _ilanResimService;
        private IIlService _ilService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        public AdminController(IIlanService ilanService, IMarkaService markaService, IResimService ilanResimService, IIlService ilService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _ilanService = ilanService;
            _markaService = markaService;
            _ilanResimService = ilanResimService;
            _roleManager = roleManager;
            _userManager = userManager;
            _ilService = ilService;
        }
        public IActionResult Index()
        {
            ViewBag.userCount = _userManager.Users.Count();
            ViewBag.confirmedUserCount = _userManager.Users.Where(i => i.EmailConfirmed == true).Count();
            ViewBag.ilanCount = _ilanService.GetIlanlar("").Count();
            ViewBag.enÇokIlanVerilenIl = _ilService.enÇokIlanVerilenIl();
            ViewBag.enAzIlanVerilenIl = _ilService.enAzIlanVerilenIl();

            return View();
        }


        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);

                ViewBag.Roles = roles;
                return View(new UserDetailModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailComfirmed = user.EmailConfirmed,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/user/list");
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.Address = model.Address;
                    user.PhoneNumber = model.PhoneNumber;
                    user.EmailConfirmed = model.EmailComfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/user/list");
                    }
                }
                return Redirect("/admin/user/list");
            }
            return View(model);
        }
        public async Task<IActionResult> UserDelete(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.DeleteAsync(user);
            var ilanlar = _ilanService.GetIlanlar("").Where(i => i.userId == userId).ToList();
            foreach (var ilan in ilanlar)
            {
                _ilanService.Delete(ilan);
            }
            return Redirect("/admin/user/list");
        }


        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name)
                                ? members : nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);
        }
        public async Task<IActionResult> RoleDelete(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return Redirect("/admin/role/list");
        }


        public IActionResult IlanList(string url)
        {
            return View(new IlanListViewModel()
            {
                ilanlar = _ilanService.GetIlanlar(url)
            });
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
                anasayfa = entity.anasayfa,

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
            entity.anasayfa = ilanmodel.anasayfa;
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
                        _ilanResimService.Create(resim);

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

            return Redirect("/admin/ilan/list");
        }
        public IActionResult IlanDelete(int ilanid)
        {
            var ılan = _ilanService.GetById(ilanid);
            if (ılan != null)
            {
                _ilanService.Delete(ılan);
            }
            return Redirect("/admin/ilan/list");
        }


        [HttpGet]
        public IActionResult MarkaList()
        {
            var model = new MarkaListViewModel()
            { Markalar = _markaService.GetMarkalar() };
            return View(model);
        }
        [HttpGet]
        public IActionResult MarkaCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MarkaCreate(MarkaModel marka)
        {
            var entity = new Marka()
            {
                adi = marka.adi,
                url = marka.url

            };
            _markaService.Create(entity);
            return Redirect("/admin/marka/list");
        }
        [HttpGet]
        public IActionResult MarkaEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _markaService.GetByIdWithIlanlar((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new MarkaModel()
            {
                MarkaId = entity.MarkaId,
                adi = entity.adi,
                url = entity.url,
                Ilanlar = entity.Ilanlar.ToList()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult MarkaEdit(MarkaModel markamodel)
        {
            var entity = _markaService.GetById(markamodel.MarkaId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.adi = markamodel.adi;
            entity.url = markamodel.url;
            _markaService.Update(entity);


            return Redirect("/admin/marka/list");
        }
        public IActionResult MarkaDelete(int markaid)
        {
            var entity = _markaService.GetById(markaid);
            if (entity != null)
            {
                _markaService.Delete(entity);
            }
            return Redirect("/admin/marka/list");
        }


        [HttpGet]
        public IActionResult IlList()
        {
            var model = new IlListViewModel()
            { Iller = _ilService.GetIller() };
            return View(model);
        }
        [HttpGet]
        public IActionResult IlCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult IlCreate(IlModel il)
        {
            var entity = new Il()
            {
                adi = il.adi,

            };
            _ilService.Create(entity);
            return Redirect("/admin/il/list");
        }
        [HttpGet]
        public IActionResult IlEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _ilService.GetByIdWithIlanlar((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new IlModel()
            {
                ilId = entity.ilId,
                adi = entity.adi,
                Ilanlar = entity.Ilanlar.ToList()
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult IlEdit(IlModel ilModel)
        {
            var entity = _ilService.GetById(ilModel.ilId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.adi = ilModel.adi;
            _ilService.Update(entity);

            return Redirect("/admin/il/list");
        }

        public IActionResult IlDelete(int ilId)
        {
            var entity = _ilService.GetById(ilId);
            if (entity != null)
            {
                _ilService.Delete(entity);
            }
            return Redirect("/admin/il/list");
        }
    }
}