using AuthMongoDB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthMongoDB.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _usermanager;
        public UserController(UserManager<ApplicationUser> usermanager)
        {
            this._usermanager = usermanager;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appuser = new ApplicationUser
                {
                    UserName = user.Name,
                    Email = user.email
                };
                IdentityResult result = await _usermanager.CreateAsync(appuser, user.password);
                if (result.Succeeded)
                {
                    ViewBag.message = "user created successfully";
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                

            }
            return View(user);

        }
    }
}
