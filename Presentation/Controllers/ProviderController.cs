using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Presentation.Controllers
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
        public async Task<ActionResult> Index()
        {
            return View(await providerRepository.ActivesAsync());
        }

        // GET: StudentController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.Groups = new SelectList(await groupRepository.ActivesAsync(), "Id", "Name");
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Provider provider)
        {
            try
            {
                await providerRepository.AddAsync(provider);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await providerRepository.GetByIdAsync(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await providerRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
