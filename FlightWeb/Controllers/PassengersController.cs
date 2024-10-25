using FlightHandling;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightWeb.Controllers
{
  public class PassengersController : Controller
  {
    static List<PassengerDetails> _passengers = new List<PassengerDetails>();
    static PassengersController()
    {
      for (int i = 0; i < 10; ++i)
      {
        _passengers.Add(new PassengerDetails("Fred" + i, 10 + i));
      }
    }

    // GET: PassengersController
    public ActionResult Index()
    {
      return View(_passengers);
    }

    // GET: PassengersController/Details/5
    public ActionResult Details(string id)
    {
      var pd = _passengers.FirstOrDefault(p => p.Name == id);
      if (pd == null) return NotFound();
      return View(pd);
    }

    // GET: PassengersController/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: PassengersController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
    [Authorize()]
    // GET: PassengersController/Edit/5
    public ActionResult Edit(string id)
    {
      var pd = _passengers.FirstOrDefault(p => p.Name == id);
      if (pd == null) return NotFound();
      return View(pd);
    }
    [Authorize()]
    // POST: PassengersController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(string id, PassengerDetails collection)
    {
      if (ModelState.IsValid)
      {
        try
        {
          _passengers.Add(collection);
          return RedirectToAction(nameof(Index));
        }
        catch
        {
          return View(collection);
        }
      }else{
        return View(collection);
      }
    }

    // GET: PassengersController/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: PassengersController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}
