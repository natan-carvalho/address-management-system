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
            try
            {
                if (ModelState.IsValid)
                {
                    _addressRepository.Add(address);
                    TempData["SuccessMessage"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(address);
            }
            catch (System.Exception error)
            {
                TempData["ErrorMessage"] = $"Ops, não foi possivel cadastar o endereço, detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
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
            try
            {
                if (ModelState.IsValid)
                {
                    _addressRepository.Update(address);
                    TempData["SuccessMessage"] = "Endereço atualizado com sucesso.";
                    return RedirectToAction("Index");
                }

                return View(address);
            }
            catch (System.Exception error)
            {
                TempData["ErrorMessage"] = $"Ops, não foi possivel atualizar o endereço, detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }

        }


        public IActionResult DeleteComfirm(int? id)
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

        public IActionResult Delete(int? id)
        {
            try
            {
                if (id is null or 0)
                {
                    return NotFound();
                }
                bool deleted = _addressRepository.Delete((int)id);

                if (deleted)
                {
                    TempData["SuccessMessage"] = "Endereço excluido com sucesso.";
                }
                else
                {
                    TempData["ErrorMessage"] = "Ops, não foi possivel excluir o endereço!";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception error)
            {
                TempData["ErrorMessage"] = $"Ops, não foi possivel excluir o endereço, detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}