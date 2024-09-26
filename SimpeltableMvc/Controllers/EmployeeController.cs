using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using SimpeltableMvc.Models;

namespace SimpeltableMvc.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context =new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        //Employee/showdata
        public IActionResult showdata()
        {
            List<Employeee> getallEmp = context.employees.ToList();
            return View("showdata", getallEmp);
        }
    }
}
