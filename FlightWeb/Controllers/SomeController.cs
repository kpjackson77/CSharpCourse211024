using Microsoft.AspNetCore.Mvc;

namespace FlightWeb.Controllers
{
  public class SomeController: Controller
  {
    public IActionResult SomeText()
    {
      return new ContentResult() { Content = "Greetings" };
    }
    public IActionResult MoreText(string text)
    {
    return this.Content("Somthing else!");
    }
  }
}
