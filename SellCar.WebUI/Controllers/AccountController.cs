using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sellcar.webui.Identity;
using sellcar.webui.Models;

namespace sellcar.webui.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl,
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu kullanıcı adı ile daha önce hesap oluşturulmamış");
                return View(model);
            }

            //if (!await _userManager.IsEmailConfirmedAsync(user))
            //{
            //    ModelState.AddModelError("", "Lütfen email hesabınıza gelen link ile üyeliğinizi onaylayınız.");
            //    return View(model);
            //}

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            var isAdmin = _userManager.IsInRoleAsync(user, "admin");
            if (result.Succeeded)
            {
                if (isAdmin.Result)
                {
                    return Redirect("/admin");
                }
                TempData["message"] = "Giriş Yapıldı.";
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Girilen kullanıcı adı veya parola yanlış");
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                MembershipDate = DateTime.Now
            };
            var mail = await _userManager.FindByEmailAsync(model.Email);
            var username = await _userManager.FindByNameAsync(model.UserName);
            if (mail == null && username==null)
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Password", error.Description);
                    }
                }
          
            }
            if (mail!=null)
            {
                ModelState.AddModelError("Email", "Bu email daha önce siteye kayıt olmak için kullanılmış.");
            }
            if (username!=null)
            {
                ModelState.AddModelError("UserName", "Bu kullanıcı adına sahip başka bir kişi bulunuyor.");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["message"] = "Çıkış Yapıldı.";
            return Redirect("~/");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}