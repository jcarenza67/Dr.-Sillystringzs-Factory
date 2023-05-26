using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        Machines[] Machines = _db.Machines.ToArray();
        Engineer[] Engineers = _db.Engineers.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("machines", machines);
        model.Add("machines", machines);
        return View(model);
      }
    }
}