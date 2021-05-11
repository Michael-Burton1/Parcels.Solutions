using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}