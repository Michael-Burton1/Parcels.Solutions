using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EpicodusShipping.Models;

namespace EpicodusShipping.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Form() { return View(); }

    // [Route("/parcel")]
    // public ActionResult ParcelInfo(string w, string x, string y, string z)
    // {
    //   Parcel myParcel = new(
    //     Convert.ToDouble(w),
    //     Convert.ToDouble(x),
    //     Convert.ToDouble(y),
    //     Convert.ToDouble(z)
    //   );
    //   return View(myParcel);
    // }

    [HttpGet("/parcel-info")]
    public ActionResult ParcelInfo()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }


    [HttpPost("/parcel")]
    public ActionResult Create(string w, string x, string y, string z)
    {
      Parcel myParcel = new(
        Convert.ToDouble(w),
        Convert.ToDouble(x),
        Convert.ToDouble(y),
        Convert.ToDouble(z)
      );
      return RedirectToAction("ParcelInfo");
    }

  }
}

