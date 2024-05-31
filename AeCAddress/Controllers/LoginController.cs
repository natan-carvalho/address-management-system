using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AeCAddress.Models;
using AeCAddress.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AeCAddress.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            try
            {
                UserModel user = _userRepository.FindByLogin(login.Usuario);
                if (user != null)
                {
                    if (user.PasswordIsValid(login.Senha))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                return View("Index");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}