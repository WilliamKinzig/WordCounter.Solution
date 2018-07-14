using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Splash()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/summary")]
    public ActionResult summary()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      newRepeatCounter.SetWordToCount(Request.Query["word"]);
      newRepeatCounter.SetParagraph(Request.Query["sentence"]);
      return View("Summary",newRepeatCounter);
    }

    [Route("/blah")]
    public ActionResult Summary()
    {
      return View();
    }

    // [Route("/solution")]
    // public ActionResult Solution()
    // {
    //   return View();
    // }
  }
}
