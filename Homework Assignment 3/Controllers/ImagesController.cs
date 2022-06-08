using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_Assignment_3.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
            List<Models.ImageModel> Images = new List<Models.ImageModel>();
            Images.Add(new Models.ImageModel { });
            return View(Images);
            
        }
    }
}