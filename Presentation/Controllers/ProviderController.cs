using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Presentation.Models;
using VitruviSoft.SamvelAvagyan.Repository.Models;
using VitruviSoft.SamvelAvagyan.Services;

namespace VitruviSoft.SamvelAvagyan.Presentation.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderService providerService;
        private readonly IGroupService groupService;

        public ProviderController(IProviderService providerService, IGroupService groupService)
        {
            this.providerService = providerService;
            this.groupService = groupService;
        }

        // GET: ProviderController
        public async Task<ActionResult> Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Provider, ProviderViewModel>());

            var mapper = new Mapper(config);

            var providers = mapper.Map<List<ProviderViewModel>>(await providerService.ActivesAsync());
            return View(providers);
        }

        // GET: StudentController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.Groups = new SelectList(await groupService.ActivesAsync(), "Id", "Name");
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Provider provider)
        {
            try
            {
                await providerService.AddAsync(provider);
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
            return View(await providerService.GetByIdAsync(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await providerService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
