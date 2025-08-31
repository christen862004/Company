using Company.Reposiotry;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IFakeRepo fakeRepo;

        public ServiceController(IFakeRepo fakeRepo)
        {
            this.fakeRepo = fakeRepo;
        }
        public IActionResult Index()
        {
            ViewBag.Id = fakeRepo.Id;
            return View();
        }
    }
}
