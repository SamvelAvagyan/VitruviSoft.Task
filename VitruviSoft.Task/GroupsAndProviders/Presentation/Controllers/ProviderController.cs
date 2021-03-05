using BusinessLogic;
using BusinessObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Presentation.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderRepository providerRepository;
        private readonly IGroupRepository groupRepository;

        public ProviderController(IProviderRepository providerRepository, IGroupRepository groupRepository)
        {
            this.providerRepository = providerRepository;
            this.groupRepository = groupRepository;
        }

        // GET: ProviderController
        public ActionResult Index()
        {
            return View(providerRepository.GetAll());
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Groups = new SelectList(groupRepository.GetAll(), "Id", "Name");
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Provider provider)
        {
            try
            {
                providerRepository.Add(provider);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
