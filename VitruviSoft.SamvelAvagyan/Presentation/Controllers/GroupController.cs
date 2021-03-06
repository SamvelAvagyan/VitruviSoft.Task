using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public ActionResult Index()
        {
            return View(groupRepository.Actives());
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Group group)
        {
            try
            {
                groupRepository.Add(group);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }
    }
}
