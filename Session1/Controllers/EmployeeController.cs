using Microsoft.AspNetCore.Mvc;
using Session1.Data;

namespace Session1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext context = new EmployeeContext();  
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("read",employees);
        }
    }
}
