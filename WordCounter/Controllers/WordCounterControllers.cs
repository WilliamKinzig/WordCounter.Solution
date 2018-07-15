using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordsCounter.Controllers
{
  public class WordsController : Controller
  {
    [Route("/form")]
    public ActionResult UserInputForm()
    {
      return View();
    }

    [Route("/summary")]
    public ActionResult Summary()
    {

      // RepeatCounter newRepeatCounter = new RepeatCounter();
      // newRepeatCounter.SetWordToCount(Request.Query["word"]);
      // newRepeatCounter.SetParagraph(Request.Query["sentence"]);

      RepeatCounter newRepeatCounter = new RepeatCounter(Request.Query["word"],Request.Query["sentence"]);

      return View("Summary",newRepeatCounter);
    }
  }
}
