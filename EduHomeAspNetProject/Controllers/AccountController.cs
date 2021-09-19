using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
                return View(registerVM);
            AppUser user = new AppUser
            {
                Fullname = registerVM.Fullname,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, registerVM.Password);
            if (!identityResult.Succeeded)
                foreach (var err in identityResult.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                    return View(registerVM);
                }
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
           
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser user = await _userManager.FindByEmailAsync(loginVM.Email);
            if (user==null)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View(loginVM);
            }
            if (user.HasDeleted==true)
            {
                ModelState.AddModelError("", "User Deleted");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
