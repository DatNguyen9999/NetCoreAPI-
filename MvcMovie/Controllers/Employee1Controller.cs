using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class Employee1Controller : Controller
    {
        public IActionResult Index()
        {
             return View();
        } 
         [HttpPost]
        public IActionResult Index(Employee1 ps1)
        {
        string strOutput = "Xin Chao" + ps1.Id + "-" + ps1.Ten + "-" + ps1.Age + "-" + ps1.Luong + "-" + ps1.Address;
        @ViewBag.infoShow = strOutput;
        return View();
        }     
    }
       
}