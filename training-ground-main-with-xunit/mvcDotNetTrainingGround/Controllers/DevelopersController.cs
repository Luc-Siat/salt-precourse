using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;

namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
{
  private Db _db;
  public DevelopersController(Db db)
  {
    _db = db;
  }
  [HttpGet]
  public IActionResult Index()
  {
    var listofDevs = new List<DeveloperViewModel>();
    foreach (var developer in _db.Developers)
    {
      var devToAdd = new DeveloperViewModel(){
        Id = developer.Id,
        Name = developer.Name,
        Email = developer.Email
      };
      listofDevs.Add(devToAdd);
    }
    return View(listofDevs);
  }
  [HttpGet]
  public IActionResult Details(int id)
  {
    var developer = _db.Developers.Find(dev => dev.Id == id);
    var devViewModel = new DeveloperViewModel(){ Id = developer.Id, Name = developer.Name, Email = developer.Email};
    return View(devViewModel);
  }

  [HttpGet]
  public IActionResult Create()
  {

    return View();
  }

  [HttpPost]
  public IActionResult Create(CreateNewDeveloperViewModel viewModel)
  {
    if ( ModelState.IsValid)
    {
      var nextId = _db.Developers.Count + 1;
      var newDev = new Developer()
      {
        Id = nextId,
        Name = viewModel.Name,
        Email = viewModel.Email
      };
      _db.Developers.Add(newDev);
      // RedirectToAction(nameof(Index));
      return RedirectToAction(nameof(Details), new { id = nextId });
    }
  return RedirectToAction(nameof(Create));
  }
}
