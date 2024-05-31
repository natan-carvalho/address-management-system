using System.Text;
using AeCAddress.Helpers;
using AeCAddress.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AeCAddress.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMySession _session;

        public AddressController(IAddressRepository addressRepository, IMySession session)
        {
            _addressRepository = addressRepository;
            _session = session;
        }

        public IActionResult Index()
        {
            int userId = _session.GetSession().Id;
            List<AddressModel> addresses = _addressRepository.ListAll(userId);
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
                    int userId = _session.GetSession().Id;
                    address.UsuarioID = userId;
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

        public IActionResult ExportCSV()
        {
            string fileSvgPath = "./wwwroot/list_address.csv";
            int userId = _session.GetSession().Id;
            List<AddressModel> addresses = _addressRepository.ListAll(userId);

            string header = "ID; CEP; LOGRADOURO; COMPLEMENTO; BAIRRO; CIDADE; UF; NUMERO";

            using (StreamWriter writer = new(fileSvgPath, false, Encoding.UTF8))
            {
                writer.WriteLine(header);

                foreach (AddressModel address in addresses)
                {
                    writer.WriteLine(address.ToString());
                }
            }

            return Redirect("/list_address.csv");
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