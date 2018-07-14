using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    // [Route("/Form")]
    // public ActionResult Form()
    // {
    //   return View();
    //   RepeatCounter newRepeatCounter = new RepeatCounter();
    //
    //   //selects whatever is entered in our form under the name field.
    //   newRepeatCounter.SetWordToCount(Request.Query["word"]);
    //   newRepeatCounter.SetParagraph(Request.Query["sentence"]);
    //   newRepeatCounter.GetResults();
    //   // The first argument is "Hello". This is the name of the template we want the ActionResult to use when compiling the HTML.
    //   return View("Solution", newRepeatCounter);
    //   // You also see that we never created a file called GreetingCard.cshtml, because by passing the "Hello" argument to the View() method, we were able to reuse a template from another view.
    // }
  }
}
