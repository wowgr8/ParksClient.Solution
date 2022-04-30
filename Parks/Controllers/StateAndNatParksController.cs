using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parks.Models;

namespace Parks.Controllers
{
  public class StateAndNatParksController : Controller
  {
    public IActionResult Index()
    {
      var allStateAndNatParks = StateAndNatPark.GetStateAndNatParks();
      return View(allStateAndNatParks);
    }
  }
}
