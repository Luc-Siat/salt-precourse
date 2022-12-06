using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System;
using Microsoft.AspNet.WebApi.Core;
using System.Web.Http.Filters;



namespace AddressBook.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AddressesController : ControllerBase
{
  private Db _db;
  public AddressesController(Db db)
  {
    _db = db;
  }

  [HttpGet]
  public List<CreateAddressResponse> GetAllAddresses()
  {
    var ListOfAddressResponse = new List<CreateAddressResponse>();
    foreach (var address in _db.Addresses)
    {
      var addressResponse = new CreateAddressResponse(){Id= address.Id, Name = address.Name, StreetNo = address.StreetNo, StreetName = address.StreetName, City= address.City };
      ListOfAddressResponse.Add(addressResponse);
    }
    return ListOfAddressResponse;
  }

  // To add UPDATE, DELETE
  [HttpPatch]
  public IActionResult UpdateAnAddress(UpdateAddressRequest request)
  {
   _db.Addresses.RemoveAt(request.Id);
    var updatedAddress = new Address() {
      Id = request.Id,
      Name = request.Name,
      StreetNo = request.StreetNo,
      StreetName = request.StreetName,
      City = request.City
      };
   _db.Addresses.Insert(updatedAddress.Id, updatedAddress);

   return CreatedAtAction(nameof(UpdateAnAddress), new {id = updatedAddress.Id}, updatedAddress);
  }

  [HttpDelete("{id}")]
  public Address DeleteAnAddress(int id)  {
    var address = _db.Addresses.Find( address => address.Id == id);
    _db.Addresses.RemoveAt(id);

    return address;
  }

  [HttpGet("id/{id:int}")]
  public CreateAddressResponse? GetAddressById(int id)
  {
    var address = _db.Addresses.Find( address => address.Id == id );
    var addressResponse = new CreateAddressResponse() {Name= address.Name, Id= address.Id, StreetNo = address.StreetNo, StreetName = address.StreetName, City= address.City };
    return addressResponse;
  }

  [HttpPost]
  public IActionResult CreateAnAddress(CreateAddressRequest request)
  {
    var nextId = _db.Addresses.Count + 1;
    Address address = new Address() {
      Id = nextId,
      Name = request.Name,
      StreetNo = request.StreetNo,
      StreetName = request.StreetName,
      City = request.City};

    _db.Addresses.Add(address);

    return CreatedAtAction(nameof(GetAddressById), new { id = nextId}, address );
  }


  [HttpGet("search/{stringParameter}")]
  public List<CreateAddressResponse> SearchAdressesByString(string stringParameter)
  {
    List<Address> matchingAddresses = new List<Address>();

      foreach (var address in _db.Addresses)
    {

      stringParameter = stringParameter.ToLower();
      if (address.Name.ToLower() == stringParameter)
        {
          matchingAddresses.Add(address);
        }
      if (address.StreetName.ToLower() == stringParameter)
        {
          matchingAddresses.Add(address);
        }
      if (address.City.ToLower() == stringParameter)
        {
          matchingAddresses.Add(address);
        }
    }


    var ListOfAddressesResponse = new  List<CreateAddressResponse>();
    for (int i = 0; i < matchingAddresses.Count; i++ )
    {
      var address = matchingAddresses[i];
      var addressResponse = new CreateAddressResponse() { Name= address.Name, Id= address.Id, StreetNo = address.StreetNo, StreetName = address.StreetName, City= address.City  };
      ListOfAddressesResponse.Add(addressResponse);
    }
    return ListOfAddressesResponse;
  }


  public class AllowCrossSiteJsonAttribute: ActionFilterAttribute
  {
      public override void OnActionExecuting(ActionExecutingContext filterContext)
      {
              filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");

          base.OnActionExecuting(filterContext);
      }
  }


  // REFACTO VERSION TO IMPLEMENT ONCE THE TOP ONE WORKS

  // [Route("/api/[controller]/search/{stringParameter}")]
  // [HttpGet("{stringParameter}")]
  // public List<CreateAddressResponse> GetAdressesByString(string stringParameter)
  // {
  //   List<Address> matchingAddresses = getMatchingAddress(stringParameter);
  //   var ListOfAddressesResponse = new  List<CreateAddressResponse>();
  //   for (int i = 0; i < matchingAddresses.Count; i++ )
  //   {
  //     var address = matchingAddresses[i];
  //     var addressResponse = new CreateAddressResponse() { Name= address.Name, Id= address.Id, StreetNo = address.StreetNo, StreetName = address.StreetName, City= address.City  };
  //     ListOfAddressesResponse.Add(addressResponse);
  //   }
  //   return ListOfAddressesResponse;
  // }

  // private

  // public List<Address> getMatchingAddress(string stringParameter)
  // {
  //   List<Address> matchingAddresses = new List<Address>();

  //   foreach (var address in _db.Addresses)
  //   {
  //     if (address.Name == stringParameter)
  //       {
  //         matchingAddresses.Add(address);
  //       }
  //     if (address.StreetName == stringParameter)
  //       {
  //         matchingAddresses.Add(address);
  //       }
  //     if (address.City == stringParameter)
  //       {
  //         matchingAddresses.Add(address);
  //       }
  //   }
  //   return matchingAddresses;
  // }
}
