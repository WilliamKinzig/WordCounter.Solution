using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Splash()
    {
      return View();
    }
  }
}
