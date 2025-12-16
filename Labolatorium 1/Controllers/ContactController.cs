using Microsoft.AspNetCore.Mvc;
using Labolatorium_1.Models;

namespace Labolatorium_1.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.GetContacts());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.AddContact(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _contactService.GetContactById(id);
            return contact != null ? View(contact) : NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Contact model)
        {
            if (ModelState.IsValid)
            {
                if (_contactService.UpdateContact(model))
                    return RedirectToAction("Index");
                return NotFound();
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _contactService.GetContactById(id);
            return contact != null ? View(contact) : NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.GetContactById(id);
            return contact != null ? View(contact) : NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.DeleteContactById(id);
            return RedirectToAction("Index");
        }
    }
}
