using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
  private Db _db;
  public DevelopersController(Db db)
  {
    _db = db;
  }

  [HttpGet]
  public List<CreateDeveloperResponse> GetAllDevs() {

    var listOfDeveloperResponse = new List<CreateDeveloperResponse>();
    for(int i = 0; i < _db.Developers.Count; i ++)
    {
      var developer = _db.Developers[i];
      var developerResponse = new CreateDeveloperResponse(){ Id = developer.Id, Name = developer.Name, Email = developer.Email};
      listOfDeveloperResponse.Add(developerResponse);
    };
    return listOfDeveloperResponse;
  }

  [HttpGet("{id}")]
  public CreateDeveloperResponse?  GetDeveloperById(int id)
  {
    var developerToReturn =  _db.Developers.Find( d => d.Id == id);
    var response = new CreateDeveloperResponse() {Id = developerToReturn.Id, Name = developerToReturn.Name, Email = developerToReturn.Email};
    return response;
  }

  [HttpPost]
  public IActionResult CreateNewDevelopper( CreateDeveloperRequest request)
  {
    int nextId = _db.Developers.Count + 1;

    Developer developerToAdd = new Developer() {Id = nextId, Name = request.Name, Email =  request.Email};
    _db.Developers.Add(developerToAdd);

    return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId}, developerToAdd);
  }






  public class Db
  {
    public Db()
    {
      Developers = new List<Developer>() {
        new Developer() { Id = 1, Name = "Marcus", Email = "marcus@salt.dev" },
        new Developer() { Id = 2, Name = "Beatrice", Email = "bea@salt.dev" },
      };
    }
    public List<Developer> Developers { get; set; }
  }
}
