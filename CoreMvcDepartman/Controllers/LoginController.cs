using CoreMvcDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreMvcDepartman.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
		public async Task<IActionResult> GirisYap(Admin p)
		{
            var bilgiler=c.Admins.FirstOrDefault(x=>x.Kullanici==p.Kullanici && x.sifre==p.sifre);
            if (bilgiler!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Personel");
            }
			return View();
		}
	}
}
