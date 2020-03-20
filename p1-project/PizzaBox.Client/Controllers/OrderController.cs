using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View(new PizzaViewModel());
    }

    [HttpGet]
    public IActionResult Create(long? id)
    {
      if (id == null)
      {
          return NotFound();
      }
      return View(new OrderViewModel());
    }

    [HttpPost]
    public IActionResult Create(PizzaViewModel pizzaViewModel)
    {
      return View();
    }
  }
}