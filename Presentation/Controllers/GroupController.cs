using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Presentation.Dtos;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Presentation.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupRepository groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        // GET: GroupController
        public async Task<ActionResult> Index()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupViewModel>());

            var mapper = new Mapper(config);

            var groups = mapper.Map<List<GroupViewModel>>(await groupRepository.ActivesAsync());
            return View(groups);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Group group)
        {
            try
            {
                await groupRepository.AddAsync(group);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await groupRepository.GetByIdAsync(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await groupRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
