using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_Assignment_3.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            List<Models.FileModel> Files = new List<Models.FileModel>();
            Files.Add(new Models.FileModel { });
                return View(Files);
        }
       
    }
}