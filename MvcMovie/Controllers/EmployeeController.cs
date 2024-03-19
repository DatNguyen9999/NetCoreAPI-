using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Id, string FullName, string Age, string Luong )
        {
            string strOutput = "xin chao " + Id + " - " + FullName + " - " + Age + " - " + Luong + " - " ;
            ViewBag.infoEmployee = strOutput;
            return View();
        }

    }
}