using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Find(TimeDto date)
        {
            List<UserDto> Ud =  ApplicationDbContext.users.Where(x=>x.DateTime == date.DateTime).ToList();
            return View(Ud);
        }
    }
}
