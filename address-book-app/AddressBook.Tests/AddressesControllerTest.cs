using AddressBook.Controllers;
using AddressBook.Models;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace AddressBook.Tests;

public class AddressesControllerTests
{
  IWebDriver Driver = null;
  public AddressesControllerTests()
  {
    Driver = new ChromeDriver();
  }
  // public void Dispose()
  // {
  //   if (Driver != null)
  //   {
  //     Driver.Quit();
  //     Driver = null;
  //   }
  // }
  // [Fact]
  // public void VerifyThatWebsiteExists()
  // {
  //   // Act
  //   Driver.Navigate().GoToUrl("https://www.marcusoft.net/");
  //   // http://127.0.0.1:5500/AddressBook
  //   // Assert
  //   Assert.Contains("Document", Driver.Title);
  // }

  // [Fact]
  // public void index_redirect()
  // {
  //   // act
  //   var db = new Db();
  //   var controller = new AddressesController(db);


  //   // arrange
  //   var getAll = controller.GetAllAddresses();

  //   // assert
  // Assert.NotNull(db);
  // Assert.NotNull(controller);
  // Assert.IsType<List<CreateAddressResponse>>(getAll);
  // Assert.Equal("Stuga", getAll[1].Name);
  // }
  // [Fact]
  // public void details_check()
  // {
  //   // act
  //   var db = new Db();
  //   var controller = new AddressesController(db);
  //   // arrange
  //   var details = controller.GetAddressById(0);

  //   // assert
  //   Assert.Equal("Home", details.Name);
  // }
  // [Fact]
  // public void GetAdressesByString_check()
  // {
  //   // act
  //   var db = new Db();
  //   var controller = new AddressesController(db);

  //   // arrange
  //   var byString = controller.SearchAdressesByString("Stuga");
  //   // assert
  //   Assert.Equal(2, byString[0].StreetNo);
  // }
  // [Fact]
  // public void CreateAnAddress_check()
  // {
  //   // act
  //   var db = new Db();
  //   var controller = new AddressesController(db);
  //   // arrange
  //   var mockAdress = new CreateAddressRequest(){ Name = "Sjö", StreetNo = 10, StreetName= "Strand", City= "Östersund"};
  //   var create = controller.CreateAnAddress(mockAdress);
  //   var getAll = controller.GetAllAddresses();
  //   Console.WriteLine(create);
  //   // assert
  //   Assert.Equal("Sjö", getAll[getAll.Count - 1].Name);
  // }
