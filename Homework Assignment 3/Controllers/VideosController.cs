using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_Assignment_3.Controllers
{
    public class VideosController : Controller
    {
        // GET: Videos
        public ActionResult Index()
        {
            List<Models.VideoModel> Videos = new List<Models.VideoModel>();
            Videos.Add(new Models.VideoModel{ });
            return View(Videos);
            
        }
    }
}