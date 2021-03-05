using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderRepository providerRepository;

        public ProviderController(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        // GET: ProviderController
        public ActionResult Index()
        {
            return View(providerRepository.GetAll());
        }
    }
}
