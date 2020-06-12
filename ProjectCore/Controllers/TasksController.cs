using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCore.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index(int? projectId)
        {

            Logica.BL.Tasks tasks = new Logica.BL.Tasks();



            return View();
        }
    }
}