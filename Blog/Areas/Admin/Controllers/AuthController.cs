using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using libBlog.Entity.Entities;
using libBlog.Entity.DTOs.Users;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;


        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]   
    
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous] 
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginDto.Email);  
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if(result.Succeeded) 
                    {

                        return RedirectToAction("Index", "Home", new {Area = "Admin"});   
                    }
                    else
                    {
                        ModelState.AddModelError("", "Your email address or password is incorrect.");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Your email address or password is incorrect.");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
    }
}
