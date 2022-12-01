using System;
using Xunit;
namespace mvcDotNetTrainingGround.Tests;

public class DevelopersControllerTests
{
[Fact]
  public void checking_index()
  {
    // arrange

    // act

    // assert
    Assert.Equal(
  }
//   [Fact]
//   public void checking_create()
//   {
//     // arrange
//     var controller = new DevelopersController();
//     // act
//     var result =  controller.Details(1);
//     // assert
//     var redirectToActionResult =
//       Assert.IsType<redirectToActionResult>(result);
//     Assert.Equal("Details", redirectToActionResult.ActionName);
//   }
// [Fact]
//   public void checking_details()
//   {
//     var controller = new DevelopersController();
//     // act
//     var result = controller.Create();
//     // assert
//     var redirectToActionResult =
//       Assert.IsType<redirectToActionResult>(result);
//     Assert.Equal("Create", redirectToActionResult.ActionName);
//   }
}

// [Fact]
// public async Task IndexPost_ReturnsBadRequestResult_WhenModelStateIsInvalid()
// {
//     // Arrange
//     var mockRepo = new Mock<IBrainstormSessionRepository>();
//     mockRepo.Setup(repo => repo.ListAsync())
//         .ReturnsAsync(GetTestSessions());
//     var controller = new HomeController(mockRepo.Object);
//     controller.ModelState.AddModelError("SessionName", "Required");
//     var newSession = new HomeController.NewSessionModel();

//     // Act
//     var result = await controller.Index(newSession);

//     // Assert
//     var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
//     Assert.IsType<SerializableError>(badRequestResult.Value);
// }

// [Fact]
// public async Task IndexPost_ReturnsARedirectAndAddsSession_WhenModelStateIsValid()
// {
//     // Arrange
//     var mockRepo = new Mock<IBrainstormSessionRepository>();
//     mockRepo.Setup(repo => repo.AddAsync(It.IsAny<BrainstormSession>()))
//         .Returns(Task.CompletedTask)
//         .Verifiable();
//     var controller = new HomeController(mockRepo.Object);
//     var newSession = new HomeController.NewSessionModel()
//     {
//         SessionName = "Test Name"
//     };

//     // Act
//     var result = await controller.Index(newSession);

//     // Assert
//     var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
//     Assert.Null(redirectToActionResult.ControllerName);
//     Assert.Equal("Index", redirectToActionResult.ActionName);
//     mockRepo.Verify();
// }
