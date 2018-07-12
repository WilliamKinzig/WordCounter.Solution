using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/journal")]
    public ActionResult Journal()
    {
      return View();
    }

  }
}

        // [Route("/journal")]
        // public ActionResult Journal()
        // {
        //   return View();
        // }
        // // public string Hello() { return "Hello friend!"; }
        // // public string Goodbye() { return "Goodbye friend."; }
        // [Route("/hello")]
        // public string Hello() { return "Hello friend!"; }
        //
        // [Route("/goodbye")] //route decorator
        // public string Goodbye() { return "Goodbye friend."; }

        // [Produces("text/html")] //prevent html from being treated as one big string
        // [Route("/letter")]
        // public string Letter()
        // {
        //   return
        // }
