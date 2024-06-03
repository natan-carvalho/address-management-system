using AeCAddress.Helpers;
using AeCAddress.Models;
using AeCAddress.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AeCAddress.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMySession _session;

        public LoginController(IUserRepository userRepository, IMySession session)
        {
            _userRepository = userRepository;
            _session = session;
        }

        public IActionResult Index()
        {
            if (_session.GetSession() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserModel user = _userRepository.FindByLogin(login.Usuario);
                    if (user != null)
                    {
                        if (user.PasswordIsValid(login.Senha))
                        {
                            _session.CreateSession(user);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["ErrorMessage"] = $"Ops, usuário e/ou senha invalidos. Por favor tente novamente";
                    }
                    TempData["ErrorMessage"] = $"Ops, usuário e/ou senha invalidos. Por favor tente novamente";
                }

                return View("Index");
            }
            catch (System.Exception)
            {
                TempData["ErrorMessage"] = $"Ops, não foi possivel efetuar seu login. Por favor tente novamente";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Logout()
        {
            _session.RemoveSession();
            return RedirectToAction("Index", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}