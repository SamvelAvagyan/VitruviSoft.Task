using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
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
        private readonly IMapper mapper;

        public ProviderController(IProviderService providerService, IGroupService groupService, IMapper mapper)
        {
            this.providerService = providerService;
            this.groupService = groupService;
            this.mapper = mapper;
        }

        // GET: ProviderController
        public async Task<ActionResult> Index()
        {
            var providers = await providerService.ActivesAsync();
            var providersView = providers.Select(g => mapper.Map<ProviderViewModel>(g));
            return View(providersView);
        }

        // GET: StudentController/Create
        public async Task<ActionResult> Create()
        {
            var groups = await groupService.ActivesAsync();
            var groupsView = groups.Select(g => mapper.Map<GroupViewModel>(g));
            ViewBag.Groups = new SelectList(groups, "Id", "Name");
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, ProviderViewModel providerViewModel)
        {
            try
            {
                var provider = mapper.Map<Provider>(providerViewModel);
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
            var providerViewModel = mapper.Map<ProviderViewModel>(await providerService.GetByIdAsync(id));
            return View(providerViewModel);
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

        // GET: StudentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var groups = await groupService.ActivesAsync();
            var groupsView = groups.Select(g => mapper.Map<GroupViewModel>(g));
            ViewBag.Groups = new SelectList(groups, "Id", "Name");
            var providerViewModel = mapper.Map<ProviderViewModel>(await providerService.GetByIdAsync(id));
            return View(providerViewModel);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(IFormCollection collection, ProviderViewModel providerViewModel)
        {
            try
            {
                var provider = mapper.Map<Provider>(providerViewModel);
                await providerService.UpdateAsync(provider);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
