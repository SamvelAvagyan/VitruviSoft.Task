using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
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
            return View(groupRepository.GetAll());
        }
    }
}
