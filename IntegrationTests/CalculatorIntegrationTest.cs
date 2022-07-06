using System.Net;
using System.Net.Http.Headers;
using CalculatorWebApplication.Domain.response;
using Newtonsoft.Json;

namespace IntegrationTests;
public class CalculatorIntegrationTest
{

    [Fact]
    public async void ShouldReturnAdditionOfNumbersOnSuccess()
    {
        await using var application = new Setup();
        var client = application.CreateClient();

        const string jsonString = "{\"firstNumber\":123,\"lastNumber\":123 }";
        using var jsonContent = new StringContent(jsonString);
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        var response = await client.PostAsync("/add", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();
        var calculatorResponse = JsonConvert.DeserializeObject<CalculatorResponse>(responseString);
        Assert.Equal(246, calculatorResponse.Data);
        Assert.Null(calculatorResponse.Error);

    }


    [Fact]
    public async void ShouldReturnSubtractionOfNumbersOnSuccess()
    {
        await using var application = new Setup();
        var client = application.CreateClient();

        const string jsonString = "{\"firstNumber\":222,\"lastNumber\":123 }";
        using var jsonContent = new StringContent(jsonString);
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        var response = await client.PostAsync("/subtract", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();
        var calculatorResponse = JsonConvert.DeserializeObject<CalculatorResponse>(responseString);
        Assert.Equal(99, calculatorResponse.Data);
        Assert.Null(calculatorResponse.Error);

    }

    [Fact]
    public async void ShouldReturnMultiplicationOfNumbersOnSuccess()
    {
        await using var application = new Setup();
        var client = application.CreateClient();

        const string jsonString = "{\"firstNumber\":222,\"lastNumber\":123 }";
        using var jsonContent = new StringContent(jsonString);
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        var response = await client.PostAsync("/multiply", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();
        var calculatorResponse = JsonConvert.DeserializeObject<CalculatorResponse>(responseString);
        Assert.Equal(27306,calculatorResponse.Data);
        Assert.Null(calculatorResponse.Error);

    }


    [Fact]
    public async void ShouldReturnDivisionOfNumbersOnSuccess()
    {
        await using var application = new Setup();
        var client = application.CreateClient();

        const string jsonString = "{\"firstNumber\":222,\"lastNumber\":123 }";
        using var jsonContent = new StringContent(jsonString);
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        var response = await client.PostAsync("/divide", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();
        var calculatorResponse = JsonConvert.DeserializeObject<CalculatorResponse>(responseString);
        Assert.Equal(1.8048780487804879, calculatorResponse.Data);
        Assert.Null(calculatorResponse.Error);

    }


    //Filter Test

    [Fact]
    public async void ShouldReturnErrorWhenDivisionOfNumbersOnFailure()
    {
        await using var application = new Setup();
        var client = application.CreateClient();

        const string jsonString = "{\"firstNumber\":0,\"lastNumber\":123 }";
        using var jsonContent = new StringContent(jsonString);
        jsonContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        var response = await client.PostAsync("/divide", jsonContent);
        
        var errorResponse = await response.Content.ReadAsStringAsync();
        Assert.True(response.StatusCode == HttpStatusCode.BadRequest);
        Assert.Equal("Divident/Divisor should be greater than zero", errorResponse);
        

    }
}