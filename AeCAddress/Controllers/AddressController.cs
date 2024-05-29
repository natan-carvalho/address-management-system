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
            List<AddressModel> addresses = _addressRepository.ListAll();
            return View(addresses);
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

        public IActionResult Update(int? id)
        {
            if (id is null or 0)
            {
                return NotFound();
            }
            AddressModel address = _addressRepository.FindOne((int)id);

            if (address == null)
            {
                return NotFound();
            }
            return View(address);
        }

        [HttpPost]
        public IActionResult Update(AddressModel address)
        {
            _addressRepository.Update(address);
            return RedirectToAction("Index");
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