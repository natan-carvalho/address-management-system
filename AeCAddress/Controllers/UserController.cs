using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AeCAddress.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AeCAddress.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserModel userAlreadyExists = _userRepository.FindByLogin(user.Usuario);
                    if (userAlreadyExists is null)
                    {
                        _userRepository.Create(user);
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["ErrorMessage"] = $"Ops, não foi possivel efetuar seu cadastro, usuário já existe. Por favor tente novamente";
                }
                return View("Create");
            }
            catch (System.Exception)
            {
                TempData["ErrorMessage"] = $"Ops, não foi possivel efetuar seu cadastro. Por favor tente novamente";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}