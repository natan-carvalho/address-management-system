using AeCAddress.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AeCAddress.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
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
        public IActionResult Create(AddressModel address)
        {
            _addressRepository.Add(address);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult DeleteComfirm()
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