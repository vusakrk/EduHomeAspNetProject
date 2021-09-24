using EduHomeAspNetProject.Areas.AdminPanel.ViewModels;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    public class AdminAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private SignInManager<AppUser> _signInManager { get; }
        public AdminAccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager,SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [Area("AdminPanel")]
        public IActionResult AdminRegister()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminRegister(AdminRegisterVM registerVM)
        {
            if (!ModelState.IsValid)
                return View(registerVM);
            AppUser user = new AppUser
            {
                Fullname = registerVM.FullName,
                UserName = registerVM.Username,
                Email = registerVM.Email,
                
                
                
            };
            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View(registerVM);
                }
            }
            await _userManager.AddToRoleAsync(user, registerVM.Role);
            return RedirectToAction("Index", "Home");
            
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return NotFound();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLoginVM loginVM)
        {
            if (!ModelState.IsValid)
                return NotFound();
            if (!User.Identity.IsAuthenticated)
                return NotFound();
            AppUser user = await _userManager.FindByEmailAsync(loginVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Username or Password is wrong");
                return View(loginVM);
            }
            if (user.HasDeleted)
            {
                ModelState.AddModelError("", "Your account permanently blocked");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginVM.Password,false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is wrong");
                return View(loginVM);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        //public async Task CreateRoles()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.SuperAdmin.ToString()));
        //    await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Admin.ToString()));
        //    await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Member.ToString()));
        //}

    }
}
