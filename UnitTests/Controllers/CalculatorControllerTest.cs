using CalculatorWebApplication.Controllers;
using CalculatorWebApplication.Domain.request;
using CalculatorWebApplication.Service.Interface;
using Moq;

namespace UnitTests.Controllers;

public class CalculatorControllerTest
{
    [Fact]
    public void ShouldReturnAdditionOfNumbersOnSuccess()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Add(firstNumber, lastNumber)).Returns(firstNumber + lastNumber);
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Addition(req);

        Assert.Equal(5, result.Data);
        Assert.Null(result.Error);
        mockMathService.Verify(service => service.Add(firstNumber, lastNumber), Times.Once);
    }


    [Fact]
    public void ShouldReturnErrorWhenAdditionOfNumbersOnFailure()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Add(firstNumber, lastNumber)).Throws(new Exception("Parsing Error"));
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Addition(req);

        Assert.Equal("Parsing Error", result.Error);
        Assert.Null(result.Data);
        mockMathService.Verify(service => service.Add(firstNumber, lastNumber), Times.Once);
    }


    [Fact]
    public void ShouldReturnSubtractionOfNumbersOnSuccess()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Subtract(firstNumber, lastNumber)).Returns(firstNumber - lastNumber);
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Subtraction(req);

        Assert.Equal(-1, result.Data);
        Assert.Null(result.Error);
        mockMathService.Verify(service => service.Subtract(firstNumber, lastNumber), Times.Once);
    }


    [Fact]
    public void ShouldReturnErrorWhenSubtractionOfNumbersOnFailure()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Subtract(firstNumber, lastNumber)).Throws(new Exception("Memory Error"));
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Subtraction(req);

        Assert.Equal("Memory Error", result.Error);
        Assert.Null(result.Data);
        mockMathService.Verify(service => service.Subtract(firstNumber, lastNumber), Times.Once);
    }




    [Fact]
    public void ShouldReturnMultiplicationOfNumbersOnSuccess()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Multiply(firstNumber, lastNumber)).Returns(firstNumber * lastNumber);
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Multiplication(req);

        Assert.Equal(6, result.Data);
        Assert.Null(result.Error);
        mockMathService.Verify(service => service.Multiply(firstNumber, lastNumber), Times.Once);
    }


    [Fact]
    public void ShouldReturnErrorWhenMultiplicationOfNumbersOnFailure()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Multiply(firstNumber, lastNumber)).Throws(new Exception("Memory Error"));
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Multiplication(req);

        Assert.Equal("Memory Error", result.Error);
        Assert.Null(result.Data);
        mockMathService.Verify(service => service.Multiply(firstNumber, lastNumber), Times.Once);
    }



    [Fact]
    public void ShouldReturnDivisionOfNumbersOnSuccess()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Divide(firstNumber, lastNumber)).Returns(firstNumber / lastNumber);
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Division(req);

        Assert.Equal(0.6666666666666666, result.Data);
        Assert.Null(result.Error);
        mockMathService.Verify(service => service.Divide(firstNumber, lastNumber), Times.Once);
    }


    [Fact]
    public void ShouldReturnErrorWhenDivisionOfNumbersOnFailure()
    {
        const double firstNumber = 2;
        const double lastNumber = 3;
        var mockMathService = new Mock<IMathService>();
        mockMathService.Setup(service => service.Divide(firstNumber, lastNumber)).Throws(new Exception("Memory Error"));
        var sut = new CalculatorController(mockMathService.Object);

        var req = new CalculatorRequest(firstNumber, lastNumber);
        var result = sut.Division(req);

        Assert.Equal("Memory Error", result.Error);
        Assert.Null(result.Data);
        mockMathService.Verify(service => service.Divide(firstNumber, lastNumber), Times.Once);
    }
}