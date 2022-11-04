using Csv.Api.Controllers;
using Csv.Api.Data.ValueObject;

using Csv.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Assert = Xunit.Assert;

namespace Csv.Test.Controllers;

[TestClass]
public class TemperatureControllerTest
{

    Mock<ITemperatureService> _service;

    TemperatureController _controller;

    public TemperatureControllerTest()
    {
        _service = new Mock<ITemperatureService>();
        _controller = new TemperatureController(_service.Object);
    }

    [TestMethod]
    public void shouldReturn200OK()
    {
        var expectedResultFromService = new List<TemperatureVO>
        {
            new TemperatureVO(temperatura: "23" , hora:"6"),
            new TemperatureVO(temperatura: "23" , hora:"6")

        };

        _service.Setup(_ => _.FindAll()).Returns(expectedResultFromService);

        var result = _controller.FindAll();

        _service.Verify(x => x.FindAll(), Times.Once);

        var objectResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(200, objectResult.StatusCode);

    }
}