using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace EpicodusShipping.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}