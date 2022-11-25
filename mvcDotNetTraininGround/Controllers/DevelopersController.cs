using Microsoft.AspNetCore.Mvc;
using mvcDotNetTraininGround.Models;

// namespace mvcDotNetTraininGround.Controllers;

public class DevelopersController : Controller
{
  private Db _db;
  public DevelopersController(Db db)
  {
    _db = db;
  }
  public IActionResult Index()
  {
    return View(_db.Developers);
  }

}
